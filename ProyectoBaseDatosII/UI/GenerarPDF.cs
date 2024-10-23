using iTextSharp.text.pdf;
using iTextSharp.text;

using System.Data;

using System.IO;

namespace UI
{
    internal class GenerarPDF
    {
        public void ImprimirFacturaPDF(DataSet dataset, string rutaArchivo)
        {
            DataTable encabezado = dataset.Tables[0];
            DataTable detalle = dataset.Tables[1];
            DataTable pago = dataset.Tables[2]; 

            
            Document documento = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter.GetInstance(documento, new FileStream(rutaArchivo, FileMode.Create));

          
            documento.Open();

            
            iTextSharp.text.Font fuenteEncabezado = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            iTextSharp.text.Font fuenteNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10);


            DataRow datosEncabezado = encabezado.Rows[0];
            string idFactura = datosEncabezado["id_Factura"].ToString();
            string idSerie = datosEncabezado["id_Serie"].ToString();
            string fechaFactura = datosEncabezado["fechaFactura"].ToString();
            string nombreCliente = datosEncabezado["Nombre_Cliente"].ToString();
            string direccionCliente = datosEncabezado["DireccionFacturacion"].ToString();
            string usuario = datosEncabezado["Nombre"].ToString();
            string montoTotal = datosEncabezado["montoTotal"].ToString();
            string totalSinDescuento = datosEncabezado["totalSinDescuento"].ToString();

           
            Paragraph titulo = new Paragraph("Factura VentaMueblesSA", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18));
            titulo.Alignment = Element.ALIGN_CENTER;
            documento.Add(titulo);

           
            documento.Add(new Paragraph("ID Factura: " + idFactura, fuenteNormal));
            documento.Add(new Paragraph("Serie: " + idSerie, fuenteNormal));
            documento.Add(new Paragraph("Fecha: " + fechaFactura, fuenteNormal));
            documento.Add(new Paragraph("Cliente: " + nombreCliente, fuenteNormal));
            documento.Add(new Paragraph("Dirección: " + direccionCliente, fuenteNormal));
            documento.Add(new Paragraph("Atendido por: " + usuario, fuenteNormal));
            documento.Add(Chunk.NEWLINE);

            
            PdfPTable tablaDetalle = new PdfPTable(5); 
            tablaDetalle.WidthPercentage = 100;
            tablaDetalle.SetWidths(new float[] { 2f, 1.2f, 1f, 0.8f, 1f });

           
            tablaDetalle.AddCell(new PdfPCell(new Phrase("Nombre del Mueble", fuenteEncabezado)));
            tablaDetalle.AddCell(new PdfPCell(new Phrase("Marca", fuenteEncabezado)));
            tablaDetalle.AddCell(new PdfPCell(new Phrase("Modelo", fuenteEncabezado)));
            tablaDetalle.AddCell(new PdfPCell(new Phrase("Cantidad", fuenteEncabezado)));
            tablaDetalle.AddCell(new PdfPCell(new Phrase("Total", fuenteEncabezado)));

            
            foreach (DataRow fila in detalle.Rows)
            {
                tablaDetalle.AddCell(new PdfPCell(new Phrase(fila["Nombre"].ToString(), fuenteNormal)));
                tablaDetalle.AddCell(new PdfPCell(new Phrase(fila["Marca"].ToString(), fuenteNormal)));
                tablaDetalle.AddCell(new PdfPCell(new Phrase(fila["Modelo"].ToString(), fuenteNormal)));
                tablaDetalle.AddCell(new PdfPCell(new Phrase(fila["cantidad"].ToString(), fuenteNormal)));
                tablaDetalle.AddCell(new PdfPCell(new Phrase(fila["Total"].ToString(), fuenteNormal)));
            }

         
            documento.Add(tablaDetalle);
            documento.Add(Chunk.NEWLINE);



            
            documento.Add(new Paragraph("Total sin descuento: " + totalSinDescuento, fuenteEncabezado));
            documento.Add(new Paragraph("Monto Total: " + montoTotal, fuenteEncabezado));


            documento.Add(Chunk.NEWLINE); 
            documento.Add(new Paragraph("Detalles de Pago:", fuenteEncabezado));

            foreach (DataRow filaPago in pago.Rows)
            {
                string tipoPago = filaPago["Nombre_TipoPago"].ToString();
                string cantidadPago = filaPago["Cantidad"].ToString();

                documento.Add(new Paragraph("Tipo de Pago: " + tipoPago, fuenteNormal));
                documento.Add(new Paragraph("Cantidad Pagada: " + cantidadPago, fuenteNormal));
                documento.Add(Chunk.NEWLINE); 
            }

            
            documento.Close();
        }
    }
}
