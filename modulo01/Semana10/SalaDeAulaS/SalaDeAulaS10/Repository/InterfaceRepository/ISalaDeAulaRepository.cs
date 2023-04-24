using SalaDeAulaS10.Models;

namespace SalaDeAulaS10.Repository.InterfaceRepository
{

    public interface IEstudanteRepository
    {
        void Adcionar(Estudante estudante);
        List<Estudante> ObterLista();
        Estudante ObeterPorId(int id);
        void Atualizar(Estudante estudante);
        void Excluir(int id);
    }
    //--------------------------------------

    //--------------------------------------
    public interface IEstudante_DisciplinaRepository
    {
        void Adcionar(Estudante_Disciplina estudante_Disciplina);
        List<Estudante_Disciplina> ObterLista();
        Estudante_Disciplina ObeterPorId(int id);
        void Atualizar(Estudante_Disciplina estudante_Disciplina);
        void Excluir(int id);
    }
    //--------------------------------------
    //--------------------------------------
    public interface IPerguntaRepository
    {
        void Adcionar(Pergunta pergunta);
        List<Pergunta> ObterLista();
        Pergunta ObeterPorId(int id);
        void Atualizar(Pergunta pergunta);
        void Excluir(int id);
    }
    //--------------------------------------
    //--------------------------------------
    public interface IProfessorRepository
    {
        void Adcionar(Professor professor);
        List<Professor> ObterLista();
        Professor ObeterPorId(int id);
        void Atualizar(Professor professor);
        void Excluir(int id);
    }
    //--------------------------------------
    //--------------------------------------
    public interface IProvaRepository
    {
        void Adcionar(Prova prova);
        List<Prova> ObterLista();
        Prova ObeterPorId(int id);
        void Atualizar(Prova prova);
        void Excluir(int id);
    }
    //--------------------------------------
    //--------------------------------------
    public interface IRespostaRepository
    {
        void Adcionar(Resposta resposta);
        List<Resposta> ObterLista();
        Resposta ObeterPorId(int id);
        void Atualizar(Resposta resposta);
        void Excluir(int id);
    }
    //--------------------------------------
    //--------------------------------------
    public interface IUsuarioRepository
    {
        void Adcionar(Usuario usuario);
        List<Usuario> ObterLista();
        Usuario ObeterPorId(int id);
        void Atualizar(Usuario usuario);
        void Excluir(int id);
    }
    //--------------------------------------
}
