using ApiAtividade1.DTO;
using MySql.Data.MySqlClient;

namespace ApiAtividade1.DAO
{
    public class CardsDAO
    {
        
            public List<CardsDTO> ListarCards()
            {
                var conexao = ConnectionFactory.Build();
                conexao.Open();

                var query = "SELECT * FROM Cards";

                var comando = new MySqlCommand(query, conexao);
                var datareader = comando.ExecuteReader();

                var cardsList = new List<CardsDTO>();

                while (datareader.Read())
                {
                    var cards = new CardsDTO();
                    cards.ID = datareader.GetInt32("ID");
                    cards.Nome = datareader.GetString("Nome");
                    cards.Tipo = datareader.GetString("Tipo");
                    cards.Artista = datareader.GetString("Artista");
                    cards.Image = datareader.GetString("Image");

                    cardsList.Add(cards);
                }

                conexao.Close();

                return cardsList;
            }
        }

    
}
