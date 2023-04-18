using TratExPersonalizadas;

class Program
{
    static void Main(string[] args)
    {
        Evento evento = new Evento();

        evento.QtdIngressosVendidos = -1;
        evento.QtdLugares = 12;

        try
        {
            if (evento.QtdIngressosVendidos <= 0)
            {
                Console.WriteLine("Nenhum ingresso vendido");//Adicionei esse If para que se QtdIngressosVendidos for 0 ou negativo,
            }                                                 //,ele imprima "Nenhum ingresso vendido" pois não faz sentido ser 0 e ser validado
            else if (evento.QtdLugares - evento.QtdIngressosVendidos > 0)
            {
                Console.WriteLine("Ingresso validado!");
                evento.ingressoVendido();
            }
            else
            {
                throw new IngressoException("Não existem mais lugares" +
                    " disponíveis para o evento");
            }
        }
        catch (IngressoException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}