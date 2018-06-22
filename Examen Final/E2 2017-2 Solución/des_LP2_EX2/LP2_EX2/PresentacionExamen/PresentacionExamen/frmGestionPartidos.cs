using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionExamen
{
    public partial class frmGestionPartidos : Form
    {
        private PartidosBL prtBL;
        private GruposBL gBL;
        private PaisBL pBL;
        private BindingList<Control.ProyWebServ.pais> paisesGrp;
        private BindingList<Control.ProyWebServ.partido> partidos;
        private String curGrp;

        public frmGestionPartidos()
        {
            InitializeComponent();
            dgvPosiciones.Columns["PAIS"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            prtBL = new PartidosBL();
            gBL = new GruposBL();
            pBL = new PaisBL();
            curGrp = "";
            cboGrupos.DataSource = gBL.getGrupos(); 
        }

        private void updtEquipos()
        {
            BindingList<Control.ProyWebServ.partido> slct = partidos;
            for(int i=0; i < paisesGrp.Count; i++)
            {
                int[] dats = prtBL.getStatsEquipo(paisesGrp[i].id, slct);
                if (dats.Count() > 1)
                {
                    paisesGrp[i].pj = dats[0];
                    paisesGrp[i].pg = dats[1];
                    paisesGrp[i].pe = dats[2];
                    paisesGrp[i].pp = dats[3];
                    paisesGrp[i].gf = dats[4];
                    paisesGrp[i].gc = dats[5];
                    paisesGrp[i].df = paisesGrp[i].gf - paisesGrp[i].gc;
                    paisesGrp[i].pts = paisesGrp[i].pg * 3 + paisesGrp[i].pe;
                }
            }
            paisesGrp = sortBList(paisesGrp);
            dgvPosiciones.DataSource = paisesGrp;
        }

        private BindingList<Control.ProyWebServ.pais> sortBList(BindingList<Control.ProyWebServ.pais> pss)
        {
            //update order of dgv bound BindingList with scores
            BindingList<Control.ProyWebServ.pais> tmp = new BindingList<Control.ProyWebServ.pais>();
            int[] ord = new int[4];
            for (int i = 0; i < pss.Count; i++)
                ord[i] = i;

            for(int i = 0; i < pss.Count; i++)
            {
                for(int j=i+1; j < pss.Count; j++)
                {
                    if (pss[ord[i]].pts < pss[ord[j]].pts)
                    {
                        int n = ord[i];
                        ord[i] = ord[j];
                        ord[j] = n;
                    }
                }
            }

            bool flg;
            for (int i = 0; i < pss.Count; i++)
            {
                flg = true;
                for (int j = i + 1; j < pss.Count; j++)
                {
                    flg = false;
                    if (pss[ord[i]].pts == pss[ord[j]].pts)
                        if (pss[ord[i]].df < pss[ord[j]].df)
                        {
                            int n = ord[i];
                            ord[i] = ord[j];
                            ord[j] = n;
                        }
                }
                if (flg) break;
            }

            for(int i=0; i < ord.Length; i++)
            {
                tmp.Add(pss[ord[i]]);
            }

            return tmp;
        }

        private void cboGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update if new index selected
            String g = (String)cboGrupos.SelectedItem;
            if(curGrp != g)
            {
                curGrp = g;
                paisesGrp = pBL.getGrupos(g);
                //dgvPosiciones.DataSource = paisesGrp;

                BindingList<int> indxs = new BindingList<int>();
                foreach(Control.ProyWebServ.pais p in paisesGrp)
                {
                    indxs.Add(p.id);
                }

                partidos = prtBL.getPartidos(indxs);
                setDataPartidos();
                updtEquipos();
            }
        }

        private void setDataPartidos()
        {
            //Update display of matches
            for(int i=0; i< partidos.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        txtGolesE1P1.Text = (partidos[i].jugado) ? partidos[i].gEqA.ToString() : "";
                        txtGolesE2P1.Text = (partidos[i].jugado) ? partidos[i].gEqB.ToString() : "";
                        lblE1P1.Text = paisesGrp[0].nombre;
                        lblE2P1.Text = paisesGrp[1].nombre;
                        setImg(pboxE1P1, partidos[i].eqA);
                        setImg(pboxE2P1, partidos[i].eqB);
                        break;
                    case 1:
                        txtGolesE1P2.Text = (partidos[i].jugado) ? partidos[i].gEqA.ToString() : "";
                        txtGolesE2P2.Text = (partidos[i].jugado) ? partidos[i].gEqB.ToString() : "";
                        lblE1P2.Text = paisesGrp[0].nombre;
                        lblE2P2.Text = paisesGrp[2].nombre;
                        setImg(pboxE1P2, partidos[i].eqA);
                        setImg(pboxE2P2, partidos[i].eqB);
                        break;
                    case 2:
                        txtGolesE1P3.Text = (partidos[i].jugado) ? partidos[i].gEqA.ToString() : "";
                        txtGolesE2P3.Text = (partidos[i].jugado) ? partidos[i].gEqB.ToString() : "";
                        lblE1P3.Text = paisesGrp[0].nombre;
                        lblE2P3.Text = paisesGrp[3].nombre;
                        setImg(pboxE1P3, partidos[i].eqA);
                        setImg(pboxE2P3, partidos[i].eqB);
                        break;
                    case 3:
                        txtGolesE1P4.Text = (partidos[i].jugado) ? partidos[i].gEqA.ToString() : "";
                        txtGolesE2P4.Text = (partidos[i].jugado) ? partidos[i].gEqB.ToString() : "";
                        lblE1P4.Text = paisesGrp[1].nombre;
                        lblE2P4.Text = paisesGrp[2].nombre;
                        setImg(pboxE1P4, partidos[i].eqA);
                        setImg(pboxE2P4, partidos[i].eqB);
                        break;
                    case 4:
                        txtGolesE1P5.Text = (partidos[i].jugado) ? partidos[i].gEqA.ToString() : "";
                        txtGolesE2P5.Text = (partidos[i].jugado) ? partidos[i].gEqB.ToString() : "";
                        lblE1P5.Text = paisesGrp[1].nombre;
                        lblE2P5.Text = paisesGrp[3].nombre;
                        setImg(pboxE1P5, partidos[i].eqA);
                        setImg(pboxE2P5, partidos[i].eqB);
                        break;
                    case 5:
                        txtGolesE1P6.Text = (partidos[i].jugado) ? partidos[i].gEqA.ToString() : "";
                        txtGolesE2P6.Text = (partidos[i].jugado) ? partidos[i].gEqB.ToString() : "";
                        lblE1P6.Text = paisesGrp[2].nombre;
                        lblE2P6.Text = paisesGrp[3].nombre;
                        setImg(pboxE1P6, partidos[i].eqA);
                        setImg(pboxE2P6, partidos[i].eqB);
                        break;
                    default:
                        break;
                }
            }
        }

        private void setImg(PictureBox pic, int pid)
        {
            //select flag image
            switch (pid)
            {
                case  1: pic.Image = PresentacionExamen.Properties.Resources.RUSIA; break;
                case  2: pic.Image = PresentacionExamen.Properties.Resources.ALEMANIA; break;
                case  3: pic.Image = PresentacionExamen.Properties.Resources.BRASIL; break;
                case  4: pic.Image = PresentacionExamen.Properties.Resources.PORTUGAL; break;
                case  5: pic.Image = PresentacionExamen.Properties.Resources.ARGENTINA; break;
                case  6: pic.Image = PresentacionExamen.Properties.Resources.BELGICA; break;
                case  7: pic.Image = PresentacionExamen.Properties.Resources.POLONIA; break;
                case  8: pic.Image = PresentacionExamen.Properties.Resources.FRANCIA; break;
                case  9: pic.Image = PresentacionExamen.Properties.Resources.ESPAÑA; break;
                case 10: pic.Image = PresentacionExamen.Properties.Resources.PERU; break;
                case 11: pic.Image = PresentacionExamen.Properties.Resources.SUIZA; break;
                case 12: pic.Image = PresentacionExamen.Properties.Resources.INGLATERRA; break;
                case 13: pic.Image = PresentacionExamen.Properties.Resources.COLOMBIA; break;
                case 14: pic.Image = PresentacionExamen.Properties.Resources.MEXICO; break;
                case 15: pic.Image = PresentacionExamen.Properties.Resources.URUGUAY; break;
                case 16: pic.Image = PresentacionExamen.Properties.Resources.CROACIA; break;
                case 17: pic.Image = PresentacionExamen.Properties.Resources.DINAMARCA; break;
                case 18: pic.Image = PresentacionExamen.Properties.Resources.ISLANDIA; break;
                case 19: pic.Image = PresentacionExamen.Properties.Resources.COSTA_RICA; break;
                case 20: pic.Image = PresentacionExamen.Properties.Resources.SUECIA; break;
                case 21: pic.Image = PresentacionExamen.Properties.Resources.TUNEZ; break;
                case 22: pic.Image = PresentacionExamen.Properties.Resources.EGIPTO; break;
                case 23: pic.Image = PresentacionExamen.Properties.Resources.SENEGAL; break;
                case 24: pic.Image = PresentacionExamen.Properties.Resources.IRAN; break;
                case 25: pic.Image = PresentacionExamen.Properties.Resources.SERBIA; break;
                case 26: pic.Image = PresentacionExamen.Properties.Resources.NIGERIA; break;
                case 27: pic.Image = PresentacionExamen.Properties.Resources.AUSTRALIA; break;
                case 28: pic.Image = PresentacionExamen.Properties.Resources.JAPON; break;
                case 29: pic.Image = PresentacionExamen.Properties.Resources.MARRUECOS; break;
                case 30: pic.Image = PresentacionExamen.Properties.Resources.PANAMA; break;
                case 31: pic.Image = PresentacionExamen.Properties.Resources.COREA_DEL_SUR; break;
                case 32: pic.Image = PresentacionExamen.Properties.Resources.ARABIA_SAUDI; break;
                default: break;
            }
        }
        
        private void saveBttn(int i, Button save, Button mod, TextBox txtA, TextBox txtB)
        {
            try
            {
                int n;
                n = int.Parse(txtA.Text);
                if (n < 0) throw new Exception();
                n = int.Parse(txtB.Text);
                if (n < 0) throw new Exception();
            }
            catch(Exception e)
            {
                MessageBox.Show("Los goles deben ser números >=0", "Error de goles");
                return;
            }

            txtB.Enabled = false;
            txtA.Enabled = false;
            mod.Enabled = true;
            save.Enabled = false;

            partidos[i].gEqA = int.Parse(txtA.Text);
            partidos[i].gEqB = int.Parse(txtB.Text);
            partidos[i].jugado = true;
            prtBL.updtPartido(partidos[i].eqA, partidos[i].eqB, partidos[i].gEqA, partidos[i].gEqB, partidos[i].jugado);
            updtEquipos();
            MessageBox.Show("Partido Guardado", "Mensaje");
        }

        private void deleteBttn(int i, Button save, Button mod, TextBox txtA, TextBox txtB)
        {
            save.Enabled = false;
            mod.Enabled = true;
            if (txtA.Enabled && txtB.Enabled)
            {
                txtA.Enabled = false;
                txtB.Enabled = false;
                txtA.Text = (partidos[i].jugado) ? partidos[i].gEqA.ToString() : "";
                txtB.Text = (partidos[i].jugado) ? partidos[i].gEqB.ToString() : "";
            }
            else
            {
                if (partidos[i].jugado)
                {
                    txtA.Enabled = false;
                    txtB.Enabled = false;
                    partidos[i].gEqA = 0;
                    partidos[i].gEqB = 0;//int.Parse(txtB.Text);
                    partidos[i].jugado = false;
                    prtBL.updtPartido(partidos[i].eqA, partidos[i].eqB, 0, 0, false);
                    txtA.Text = "";
                    txtB.Text = "";
                    updtEquipos();
                    MessageBox.Show("Partido eliminado", "Mensaje");
                }
            }
        }

        private void btnEliminarP1_Click(object sender, EventArgs e)
        {
            deleteBttn(0, btnGuardarP1, btnModificarP1, txtGolesE1P1, txtGolesE2P1);
        }

        private void btnEliminarP2_Click(object sender, EventArgs e)
        {
            deleteBttn(1, btnGuardarP2, btnModificarP2, txtGolesE1P2, txtGolesE2P2);
            //deleteBttn(, btnGuardarP, btnModificarP, txtGolesE1P, txtGolesE2P);
        }

        private void btnEliminarP3_Click(object sender, EventArgs e)
        {
            deleteBttn(2, btnGuardarP3, btnModificarP3, txtGolesE1P3, txtGolesE2P3);
        }

        private void btnEliminarP4_Click(object sender, EventArgs e)
        {
            deleteBttn(3, btnGuardarP4, btnModificarP4, txtGolesE1P4, txtGolesE2P4);
        }

        private void btnEliminarP5_Click(object sender, EventArgs e)
        {
            deleteBttn(4, btnGuardarP5, btnModificarP5, txtGolesE1P5, txtGolesE2P5);
        }

        private void btnEliminarP6_Click(object sender, EventArgs e)
        {
            deleteBttn(5, btnGuardarP6, btnModificarP6, txtGolesE1P6, txtGolesE2P6);
        }

        private void btnGuardarP1_Click(object sender, EventArgs e)
        {
            saveBttn(0,btnGuardarP1,btnModificarP1,txtGolesE1P1, txtGolesE2P1);
        }

        private void btnGuardarP2_Click(object sender, EventArgs e)
        {
            saveBttn(1, btnGuardarP2, btnModificarP2, txtGolesE1P2, txtGolesE2P2);
        }

        private void btnGuardarP3_Click(object sender, EventArgs e)
        {
            saveBttn(2, btnGuardarP3, btnModificarP3, txtGolesE1P3, txtGolesE2P3);
        }

        private void btnGuardarP4_Click(object sender, EventArgs e)
        {
            saveBttn(3, btnGuardarP4, btnModificarP4, txtGolesE1P4, txtGolesE2P4);
        }

        private void btnGuardarP5_Click(object sender, EventArgs e)
        {
            saveBttn(4, btnGuardarP5, btnModificarP5, txtGolesE1P5, txtGolesE2P5);
        }

        private void btnGuardarP6_Click(object sender, EventArgs e)
        {
            saveBttn(5, btnGuardarP6, btnModificarP6, txtGolesE1P6, txtGolesE2P6);
        }
        private void btnModificarP1_Click(object sender, EventArgs e)
        {
            txtGolesE2P1.Enabled = true;
            txtGolesE1P1.Enabled = true;
            btnGuardarP1.Enabled = true;
            btnModificarP1.Enabled = false;
        }

        private void btnModificarP2_Click(object sender, EventArgs e)
        {
            txtGolesE2P2.Enabled = true;
            txtGolesE1P2.Enabled = true;
            btnGuardarP2.Enabled = true;
            btnModificarP2.Enabled = false;
        }

        private void btnModificarP3_Click(object sender, EventArgs e)
        {
            txtGolesE2P3.Enabled = true;
            txtGolesE1P3.Enabled = true;
            btnGuardarP3.Enabled = true;
            btnModificarP3.Enabled = false;
        }

        private void btnModificarP4_Click(object sender, EventArgs e)
        {
            txtGolesE2P4.Enabled = true;
            txtGolesE1P4.Enabled = true;
            btnGuardarP4.Enabled = true;
            btnModificarP4.Enabled = false;
        }

        private void btnModificarP5_Click(object sender, EventArgs e)
        {
            txtGolesE2P5.Enabled = true;
            txtGolesE1P5.Enabled = true;
            btnGuardarP5.Enabled = true;
            btnModificarP5.Enabled = false;
        }

        private void btnModificarP6_Click(object sender, EventArgs e)
        {
            txtGolesE2P6.Enabled = true;
            txtGolesE1P6.Enabled = true;
            btnGuardarP6.Enabled = true;
            btnModificarP6.Enabled = false;
        }
    }
}
