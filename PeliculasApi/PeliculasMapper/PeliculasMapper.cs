using AutoMapper;
using PeliculasApi.Models;
using PeliculasApi.Models.Dtos;
using System.Runtime.CompilerServices;

namespace PeliculasApi.PeliculasMapper
{
    public class PeliculasMapper:Profile
    {
        public PeliculasMapper()
        {
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
            CreateMap<Categoria, CrearCategoriaDto>().ReverseMap();
        }
    }
}
