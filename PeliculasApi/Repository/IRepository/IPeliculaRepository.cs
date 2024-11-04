using PeliculasApi.Models;

namespace PeliculasApi.Repository.IRepository
{
    public interface IPeliculaRepository
    {
        ICollection<Pelicula> GetPeliculas();
        Pelicula GetPelicula(int peliculaId);
        bool ExistePelicula(string nombre);
        bool ExistePelicula(int id);
        bool CrearPelicula(Pelicula pelicula);
        bool ActualizarPelicula(Pelicula pelicula);
        bool BorrarPelicula(Pelicula pelicula);

        //metodos para buscar peliculas en categoria y buscar por nombre
        ICollection<Pelicula> GetPeliculasEnCategoria(int categoriaId);
        ICollection<Pelicula> BuscarPeliculas(string nombre);
        bool Guardar();
    }
}
