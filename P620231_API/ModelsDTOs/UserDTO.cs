namespace P620231_API.ModelsDTOs
{
    public class UserDTO
    {
        //Un DTO (data transfer object) sirve para: 
        //1. que el equipo de desarrollo del los front ends (app en este caso) 
        //no entiendan la estructura real de la tabla a nivel de base de datos. 

        //2. simplificar objetos complejos en estructuras más simples para que los 
        //json resultantes sean mucho más fáciles de gestionar. 

        //3. En caso en los que se deba regenerar los modelos por medios de 
        //scaffold -f los controles sigan trabajando con normalidad 

        //en este he decidido escribir los nombres en español solo por ejemplo de uso de DTOs
        public int IDUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string NumeroTelefono { get; set; } = null!;
        public string Contrasennia { get; set; } = null!;
        public string? Cedula { get; set; }
        public string? Direccion { get; set; }
        public int IdRol { get; set; }
        public int IdEstado { get; set; }
        public string EstadoDescripcion { get; set; } = null!;
        public string RolDescripcion { get; set; } = null!;
    }
}
