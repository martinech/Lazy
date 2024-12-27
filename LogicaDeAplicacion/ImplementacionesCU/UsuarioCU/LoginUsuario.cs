using Dto;
using LogicaDeNegocio.InterfacesRepositorios;
using LogicaDeNegocio.Entidades;
using LogicaDeNegocio.Exceptions;
using LogicaDeAplicacion.InterfacesCU.IUsuarioCU;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace LogicaDeAplicacion.ImplementacionesCU.UsuarioCU
{
    public class LoginUsuario : ILoginUsuario
    {
        private readonly IRepositorioUsuario _repositorioUsuario;

        public LoginUsuario(IRepositorioUsuario repositorio)
        {
            _repositorioUsuario = repositorio;
        }
        public UsuarioDto Ejecutar(string email, string password)
        {
            Usuario usuarioLogueado = _repositorioUsuario.Login(email, password);

            if (usuarioLogueado is not null)
            {
                UsuarioDto usuarioDto = new UsuarioDto(usuarioLogueado);
                usuarioDto.token = GenerarTokenJwt(usuarioDto.Email, usuarioDto.Rol);
                return usuarioDto;
            }
            else
                throw new UsuarioInvalidoException("Datos incorrectos");
        }

        private string GenerarTokenJwt(string email, string rol)
        {
            var claveSecreta = "claveSuperSecretaCon32CaracteresMin";

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, rol)
            };

            var clave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(claveSecreta));

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(30),
                signingCredentials: new SigningCredentials(clave, SecurityAlgorithms.HmacSha256)
            );

            string tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            return tokenString;
        }
    }
}
