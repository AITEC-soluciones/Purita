using System;
using System.Windows.Forms;

namespace Deshidratador.GUI {
    public partial class PanelNuevoPerfil : Form {

        /// <summary>
        ///     Inicializa una nueva instancia de la clase <see cref="PanelNuevoPerfil"/>
        /// </summary>
        public PanelNuevoPerfil() {
            InitializeComponent();
        }

        #region Propiedades

        /// <summary>
        ///     Nombre del perfil de deshidratación.
        /// </summary>
        public string Nombre => tbNombre.Text;

        #endregion

        #region Eventos

        /// <summary>
        ///     Almacena el nuevo perfil en la variable correspondiente y cierra el panel actual.
        /// </summary>
        private void btnCrearPerfil_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(Nombre))
                return;

            DialogResult = DialogResult.OK;

            Close();
        }

        /// <summary>
        ///     Cierra la ventana actual.
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Abort;

            Close();
        }

        #endregion        
    }
}
