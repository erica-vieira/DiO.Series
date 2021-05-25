using System.Collections.Generic;
namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T> //significa que a classe implementa implementa o repositório dessa outra classe T
    {
       List<T> Lista();
       T RetornaPorId(int id);
       void Insere (T entidade);
       void Exclui (int id);
       void Atualiza (int id, T entidade);
       int ProximoId();

    }
}