using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace InventarioEquiposFase3N.Services
{
    public sealed class ServicioFotoEmpleado
    {
        private const long TamañoMaximoBytes = 8 * 1024 * 1024;
        private readonly string _carpetaFotos;

        public ServicioFotoEmpleado(string carpetaFotos) 
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(carpetaFotos);
            _carpetaFotos = Path.Combine(Path.GetFullPath(carpetaFotos), "FotosEmpleados");
        }

        public string GuardarFoto(int empleadoId, string rutaOrigen)
        {
            if (empleadoId <= 0)
                throw new ArgumentException("El empleado debe de tener un identificador válido.", nameof(empleadoId));

            ArgumentException.ThrowIfNullOrWhiteSpace(rutaOrigen);

            string extension = Path.GetExtension(rutaOrigen).ToLowerInvariant();
            if (extension is not (".jpg" or ".jpeg" or ".png"))
                throw new ArgumentException("La imagen debe de ser un archivo JPG, JPEG o PNG.");

            try
            {
                var info = new FileInfo(rutaOrigen);
                if (!info.Exists || info.Length == 0 || info.Length > TamañoMaximoBytes)
                    throw new ArgumentException("La fotografía debe de existir y ocupar un máximo de 8MB");

                using Image imagen = Image.FromFile(rutaOrigen);
                if (imagen.Width > 6000 || imagen.Height > 6000 || imagen.Width < 1 || imagen.Height < 1)
                    throw new ArgumentException("La fotografía supera las dimensiones permitidas (6000 x 6000)");
            }
            catch (Exception ex) when (ex is OutOfMemoryException or ArgumentException) 
            { 
                throw new ArgumentException("La fotografía no es válida o está dañada.", ex);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                throw new ArgumentException("No se puede acceder a la fotografía.", ex);
            }

            string nombre = $"{empleadoId}_{Guid.NewGuid()}{extension}"; 
            string destino = Path.Combine(_carpetaFotos, nombre);

            try
            {
                Directory.CreateDirectory(_carpetaFotos);
                File.Copy(rutaOrigen, destino);
                return $"FotosEmpleados/{nombre}";
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException) 
            {
                try { if (File.Exists(destino)) File.Delete(destino); } 
                catch (Exception error) when (error is IOException or UnauthorizedAccessException) { }
                throw new IOException("No se puede guardar la fotografía.", ex);
            }
        }

        public Image? CargarImagen(string? rutaRelativa) 
        {
            string? ruta = ObtenerRutaAbsoluta(rutaRelativa);
            if (ruta is null || !File.Exists(ruta))
                return null;

            try 
            {
                using var archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using Image imagen = Image.FromStream(archivo, useEmbeddedColorManagement: false, validateImageData: true);
                return new Bitmap(imagen);
            }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
            {
                return null;
            }
        }

        public Image? CrearMiniatura(string? rutaRelativa, int ancho = 64, int alto = 64)
        {
            using Image? imagen = CargarImagen(rutaRelativa);
            if (imagen is null)
                return null;

            var miniatura = new Bitmap(ancho, alto, PixelFormat.Format32bppArgb);
            using var lienzo = Graphics.FromImage(miniatura);
            lienzo.Clear(Color.WhiteSmoke);
            lienzo.InterpolationMode = InterpolationMode.HighQualityBicubic;
            lienzo.SmoothingMode = SmoothingMode.AntiAlias;
            lienzo.PixelOffsetMode = PixelOffsetMode.HighQuality;

            float escala = Math.Min((float)ancho / imagen.Width, (float)alto / imagen.Height);
            int w = Math.Max(1, (int)(imagen.Width * escala));
            int h = Math.Max(1, (int)(imagen.Height * escala));
            lienzo.DrawImage(imagen, (ancho - w) / 2, (alto - h) / 2, w, h);
            return miniatura;
        }

        public static Image CrearImagenSinFoto(int lado = 64)
        {
            try
            {
                string ruta = Path.Combine(AppContext.BaseDirectory, "Resources", "Foto", "empleado_anonimo.png");

                if (File.Exists(ruta))
                {
                    using Image original = Image.FromFile(ruta);
                    return new Bitmap(original, new Size(lado, lado));
                }
            }
            catch
            {
            }

            var imagenTemporal = new Bitmap(lado, lado);
            using var lienzo = Graphics.FromImage(imagenTemporal);
            lienzo.Clear(Color.LightGray); 

            return imagenTemporal;
        }

        public void EliminarFoto(string? rutaRelativa)
        {
            string? ruta = ObtenerRutaAbsoluta(rutaRelativa);
            if (ruta is null)
                return;

            try { if (File.Exists(ruta)) File.Delete(ruta); }
            catch (Exception ex) when (ex is IOException or UnauthorizedAccessException) { }
        }

        private string? ObtenerRutaAbsoluta(string? rutaRelativa)
        {
            if (string.IsNullOrWhiteSpace(rutaRelativa))
                return null;

            string normalizada = rutaRelativa.Replace('\\', '/');
            const string prefijo = "FotosEmpleados/"; 
            if (!normalizada.StartsWith(prefijo, StringComparison.OrdinalIgnoreCase))
                return null;

            string nombre = normalizada[prefijo.Length..];
            if (string.IsNullOrWhiteSpace(nombre) || nombre is "." or ".." ||
                nombre != Path.GetFileName(nombre) || nombre.Contains('/') || nombre.Contains('\\'))
                return null;

            return Path.Combine(_carpetaFotos, nombre);
        }
    }
}
