using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideotecaDesktop.Enumeraciones;
using VideotecaDesktop.Models.TipoDocumento;

namespace VideotecaDesktop
{
    public partial class frmTipoDocumentos : Form
    {
        #region Declaración de variables privadas

        private bool agregarDato = false;
        private EnumTipoDeBusqueda tipoDeBusqueda;

        #endregion

        public frmTipoDocumentos()
        {
            InitializeComponent();
        }

        private void frmTipoDocumentos_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();

            pnlAceptarCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;

            txtDescripcionDocumento.MaxLength = Models.TipoDocumento.Item.MAX_LENGTH_DESCRIPCION;
            txtTipoDocumento.MaxLength = Models.TipoDocumento.Item.MAX_LENGTH_TIPO;

            txtDescripcionDocumento.Enabled = false;
            txtTipoDocumento.Enabled = false;

            Buscar(EnumTipoDeBusqueda.TOPN);
        }

        private void btnAgregar_ClickAsync(object sender, EventArgs e)
        {
            grdTipoDocumentos.Enabled = false;
            pnlAceptarCancelar.Enabled = true;

            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;

            txtBuscar.Enabled = false;
            btnBuscar.Enabled = false;
            btnTodos.Enabled = false;
            btnBorrados.Enabled = false;
   
            txtTipoDocumento.Text = "";
            txtTipoDocumento.Enabled = true;
            txtDescripcionDocumento.Text = "";
            txtDescripcionDocumento.Enabled = true;

            btnAceptar.Enabled = true;
            btnAceptar.Enabled = true;

            agregarDato = true;

            txtTipoDocumento.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (grdTipoDocumentos.Rows.Count > 0)
            {
                string dato = grdTipoDocumentos[0, grdTipoDocumentos.CurrentCell.RowIndex].Value.ToString() 
                    + " - " 
                    + grdTipoDocumentos[1, grdTipoDocumentos.CurrentCell.RowIndex].Value.ToString();

                DialogResult rest = MessageBox.Show("Desea Borrar el Tipo de Documento: \"" + dato + "\"", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (rest == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    try
                    {
                        Repositorio.TipoDocumentoRepository.Delete(int.Parse(lblID.Text));

                        Buscar(tipoDeBusqueda);

                        Cursor = Cursors.Default;
                    }
                    catch (Exception ex)
                    {
                        Cursor = Cursors.Default;

                        MessageBox.Show("Se presentó un problema al tratar de obtener los Tipo de Documentos", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            } else
            {
                MessageBox.Show("No hay Tipo de Documento a Borrar", "Obseración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscar.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            grdTipoDocumentos.Enabled = true;

            if (grdTipoDocumentos.Rows.Count > 0)
            {
                pnlAceptarCancelar.Enabled = true;

                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnBorrar.Enabled = false;

                txtBuscar.Enabled = false;
                btnBuscar.Enabled = false;
                btnTodos.Enabled = false;
                btnBorrados.Enabled = false;

                txtTipoDocumento.Text = grdTipoDocumentos[0, grdTipoDocumentos.CurrentCell.RowIndex].Value.ToString();
                txtTipoDocumento.Enabled = true;
                txtDescripcionDocumento.Text = grdTipoDocumentos[1, grdTipoDocumentos.CurrentCell.RowIndex].Value.ToString();
                txtDescripcionDocumento.Enabled = true;

                btnAceptar.Enabled = true;
                btnAceptar.Enabled = true;

                agregarDato = false;

                txtTipoDocumento.Focus();
            } else
            {
                MessageBox.Show("No hay Tipo de Documento a Modificar", "Obseración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscar.Focus();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipoDocumento.Text) || txtTipoDocumento.Text.Length > Models.TipoDocumento.Item.MAX_LENGTH_TIPO)
            {
                MessageBox.Show("Tipo de Documento no válido", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTipoDocumento.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcionDocumento.Text) || txtDescripcionDocumento.Text.Length > Models.TipoDocumento.Item.MAX_LENGTH_DESCRIPCION)
            {
                MessageBox.Show("Descripción de Documento no válido", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcionDocumento.Focus();
                return;
            }

            Cursor = Cursors.WaitCursor;
            try
            {
                Models.TipoDocumento.Item item = null;

                if (agregarDato)
                {
                    item = new Models.TipoDocumento.Item
                    {
                        Nombre = txtDescripcionDocumento.Text.Trim(),
                        Tipo = txtTipoDocumento.Text.Trim().ToUpper()
                    };

                    item.UpdatedAt = null;
                    item.CreatedAt = null;
                    item.DeletedAt = null;

                    Repositorio.TipoDocumentoRepository.Add(item);
                }
                else
                {
                    item = Repositorio.TipoDocumentoRepository.GetById(int.Parse(lblID.Text));
                    item.Nombre = txtDescripcionDocumento.Text.Trim();
                    item.Tipo = txtTipoDocumento.Text.Trim().ToUpper();
                    Repositorio.TipoDocumentoRepository.Update(int.Parse(lblID.Text), item);
                }

                Buscar(tipoDeBusqueda);

                agregarDato = false;

                btnCancelar_Click(btnAceptar, EventArgs.Empty);

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;

                MessageBox.Show("Se presentó un problema al tratar de obtener los Tipo de Documentos", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            agregarDato = false;

            grdTipoDocumentos.Enabled = true;
            pnlAceptarCancelar.Enabled = false;

            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;

            txtBuscar.Enabled = true;
            btnBuscar.Enabled = true;
            btnTodos.Enabled = true;
            btnBorrados.Enabled = true;

            txtTipoDocumento.Enabled = false;
            txtDescripcionDocumento.Enabled = false;

            btnAceptar.Enabled = false;
            btnAceptar.Enabled = false;

            if (grdTipoDocumentos.Rows.Count > 0)
            {
                if (tipoDeBusqueda == EnumTipoDeBusqueda.BORRADO)
                {
                    btnModificar.Enabled = false;
                    btnBorrar.Enabled = false;
                }

                grdTipoDocumentos.Focus();
            } else
            {
                txtTipoDocumento.Text = "";
                txtDescripcionDocumento.Text = "";
                txtBuscar.Focus();
            }
        }

        private void grdTipoDocumentos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            EnableDisableControls(false);

            if (e != null)
            {
                lblID.Text = grdTipoDocumentos[5, e.RowIndex].Value.ToString();
                txtTipoDocumento.Text = grdTipoDocumentos[0, e.RowIndex].Value.ToString();
                txtDescripcionDocumento.Text = grdTipoDocumentos[1, e.RowIndex].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(EnumTipoDeBusqueda.TEXTO);
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            Buscar(EnumTipoDeBusqueda.TODO);
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            Buscar(EnumTipoDeBusqueda.ACTIVO);
        }

        private void btnBorrados_Click(object sender, EventArgs e)
        {
            Buscar(EnumTipoDeBusqueda.BORRADO);
        }

        #region Métodos Privados

        private void EnableDisableControls(bool enabled)
        {
            txtDescripcionDocumento.Enabled = enabled;
            txtTipoDocumento.Enabled = enabled;
        }

        private void Buscar(EnumTipoDeBusqueda enumTipoBusqueda)
        {
            Cursor = Cursors.WaitCursor;

            lblID.Text = "0";
            txtDescripcionDocumento.Text = "";
            txtTipoDocumento.Text = "";

            btnBorrar.Enabled = true;
            btnModificar.Enabled = true;

            tipoDeBusqueda = enumTipoBusqueda;

            Models.TipoDocumento.ListTipoDocumentos listTipoDocumento = null;

            try
            {
                switch (enumTipoBusqueda)
                {
                    case EnumTipoDeBusqueda.TODO:
                        listTipoDocumento = Repositorio.TipoDocumentoRepository.GetAll();
                        break;
                    case EnumTipoDeBusqueda.TEXTO:
                        listTipoDocumento = Repositorio.TipoDocumentoRepository.GetByTipoAndDescripcion(txtBuscar.Text.Trim());
                        break;
                    case EnumTipoDeBusqueda.BORRADO:
                        listTipoDocumento = Repositorio.TipoDocumentoRepository.GetDeletes();
                        btnBorrar.Enabled = false;
                        btnModificar.Enabled = false;
                        break;
                    case EnumTipoDeBusqueda.TOPN:
                        listTipoDocumento = Repositorio.TipoDocumentoRepository.GetTopN(10);
                        break;
                }

                if (listTipoDocumento != null && listTipoDocumento.Total > 0)
                {
                    if (enumTipoBusqueda == EnumTipoDeBusqueda.BORRADO)
                    {
                        btnModificar.Enabled = false;
                        btnBorrar.Enabled = false;
                    }
                    
                    grdTipoDocumentos.DataSource = listTipoDocumento.Items;

                    grdTipoDocumentos[0, 0].Selected = true;

                } else
                {
                    btnModificar.Enabled = false;
                    btnBorrar.Enabled = false;

                    grdTipoDocumentos.DataSource = new List<Models.TipoDocumento.Item>();
                }


                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;

                MessageBox.Show("Se presentó un problema al tratar de obtener los Tipo de Documentos", "Observación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

    }
}
