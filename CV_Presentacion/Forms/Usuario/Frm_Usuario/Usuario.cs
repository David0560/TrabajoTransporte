namespace CV_Presentacion.Frm_Usuario
{
    internal class Usuario
    {
        private string nombre;
        private int id_empleado;
        private int id_familia;
        private string fvp;
        private string fvu;

        public Usuario(string nombre, int id_empleado, int id_familia, string fvp, string fvu)
        {
            this.nombre = nombre;
            this.id_empleado = id_empleado;
            this.id_familia = id_familia;
            this.fvp = fvp;
            this.fvu = fvu;
        }
    }
}