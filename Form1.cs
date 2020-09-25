using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Graphics Panel;
            Panel = Whiteboard.CreateGraphics();

            // Colores
            Color naranja = ColorTranslator.FromHtml("#FF8000");
            Color azul = ColorTranslator.FromHtml("#B1DDF0");
            Color amarillo = ColorTranslator.FromHtml("#FFFF00");
            Color verde1 = ColorTranslator.FromHtml("#2CDE2C");
            Color verde2 = ColorTranslator.FromHtml("#99FF33");
            Color verde3 = ColorTranslator.FromHtml("#009900");
            Color rojo = ColorTranslator.FromHtml("#E51400");
            Color rosa = ColorTranslator.FromHtml("#FF99FF");
            Color cafe = ColorTranslator.FromHtml("#6D1F00");
            Color cafeLight = ColorTranslator.FromHtml("#A0522D");
            Color negro = Color.Black;

            // Pinceles
            Pen drawNaranja = new Pen(naranja, 5);
            Pen drawAmarillo = new Pen(amarillo, 5);
            Pen drawVerde3 = new Pen(verde3, 3);
            Pen drawCafe = new Pen(cafe, 3);
            Pen drawNegro = new Pen(negro, 3);

            // Rellenos
            SolidBrush fillAzul = new SolidBrush(azul);
            SolidBrush fillAmarillo = new SolidBrush(amarillo);
            SolidBrush fillVerde1 = new SolidBrush(verde1);
            SolidBrush fillVerde2 = new SolidBrush(verde2);
            SolidBrush fillRojo = new SolidBrush(rojo);
            SolidBrush fillRosa = new SolidBrush(rosa);
            SolidBrush fillNegro = new SolidBrush(negro);
            SolidBrush fillCafe = new SolidBrush(cafeLight);

            // Nubes
            Rectangle nube1 = new Rectangle(165, 14, 60, 70);
            Rectangle nube2 = new Rectangle(790, 20, 180, 50);
            Panel.FillEllipse(fillAzul, nube1);
            Panel.FillEllipse(fillAzul, nube2);

            // Sol
            Rectangle sol = new Rectangle(50, 60, 67, 100);
            Panel.DrawLine(drawNaranja, 84, 210, 84, 10);
            Panel.DrawLine(drawNaranja, 10, 110, 160, 110);
            Panel.DrawLine(drawAmarillo, 38, 156, 128, 66);
            Panel.DrawLine(drawAmarillo, 130, 150, 40, 70);
            Panel.FillEllipse(fillAmarillo, sol);

            // Pasto
            Rectangle pasto = new Rectangle(0, 340, 1000, 110);
            Panel.FillRectangle(fillVerde2, pasto);

            // Arbol
            Rectangle arbol = new Rectangle(640, 90, 175, 175);
            Panel.FillEllipse(fillVerde1, arbol);
                // Arbol - Manzanas
                Rectangle manzana1 = new Rectangle(680, 120, 20, 30);
                Rectangle manzana2 = new Rectangle(670, 182, 20, 33);
                Rectangle manzana3 = new Rectangle(730, 110, 20, 20);
                Rectangle manzana4 = new Rectangle(770, 150, 20, 20);
                Rectangle manzana5 = new Rectangle(750, 182, 20, 20);
                Panel.FillEllipse(fillRojo, manzana1);
                Panel.FillEllipse(fillRojo, manzana2);
                Panel.FillEllipse(fillRojo, manzana3);
                Panel.FillEllipse(fillRojo, manzana4);
                Panel.FillEllipse(fillRojo, manzana5);
            Panel.DrawEllipse(drawVerde3, arbol);
            GraphicsPath tronco = new GraphicsPath();
            Rectangle tronco1 = new Rectangle(612, 220, 100, 140);
            Rectangle tronco2 = new Rectangle(742, 220, 100, 140);
            tronco.AddArc(tronco1, -70, 150);
            tronco.AddArc(tronco2, 100, 150);
            tronco.CloseFigure();
            Panel.FillPath(fillCafe, tronco);
            //Panel.DrawPath(drawCafe, tronco);
            Panel.DrawArc(drawCafe, tronco1, -70, 150);
            Panel.DrawArc(drawCafe, tronco2, 100, 150);


            // Casa
            Rectangle frontal = new Rectangle(190, 175, 150, 165);
            Rectangle lateral = new Rectangle(340, 175, 255, 165);
            Rectangle puerta = new Rectangle(230, 280, 40, 60);
            Rectangle ventana = new Rectangle(430, 230, 100, 60);

            Panel.FillRectangle(fillRosa, frontal);
            Panel.FillRectangle(fillRosa, lateral);
            Panel.FillRectangle(fillNegro, puerta);
            Panel.FillRectangle(fillAzul, ventana);
            Panel.DrawRectangle(drawCafe, frontal);
            Panel.DrawRectangle(drawCafe, lateral);
            Panel.DrawLine(drawNegro, 480, 230, 480, 290);
            Panel.DrawLine(drawNegro, 430, 250, 530, 250);
            Panel.DrawLine(drawNegro, 430, 270, 530, 270);
            Panel.DrawRectangle(drawCafe, ventana);

            Point[] techoFrontoal =
            {
                new Point(190, 175),
                new Point(265, 55),
                new Point(340, 175),
                new Point(190, 175)
            };
            Panel.FillPolygon(fillCafe, techoFrontoal);
            Panel.DrawPolygon(drawCafe, techoFrontoal);
            Point[] techoLateral =
            {
                new Point(265, 55),
                new Point(595, 55),
                new Point(595, 175),
                new Point(340, 175),
                new Point(265, 55)
            };
            Panel.FillPolygon(fillCafe, techoLateral);
            Panel.DrawPolygon(drawCafe, techoLateral);

        }
    }
}
