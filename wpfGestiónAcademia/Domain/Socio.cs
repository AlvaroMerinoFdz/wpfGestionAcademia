using System;

public class Socio
{
    public int Id { get; private set; }
    public string Nombre { get; private set; }
    public string Email { get; private set; }

    public Socio(string nombre, string email)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new Exception("El nombre es obligatorio");

        if (!email.Contains("@"))
            throw new Exception("Email inválido");

        Nombre = nombre;
        Email = email;
    }

    public void CambiarEmail(string nuevoEmail)
    {
        if (!nuevoEmail.Contains("@"))
            throw new Exception("Email inválido");

        Email = nuevoEmail;
    }
}
