namespace OASv1.Model;

public class AProductModel
{
    public Guid Id { get; init; }
    public Double Valor { get; private set; }
    public String SetorDoProduto { get; set; }
    public String NomeDoProduto { get; private set; }
    public String ResponsavelPelaBuscaDoProduto { get; private set; }
    public String NotaFiscal { get; private set; }
    public DateTime ValidadeDoProduto { get; private set; }
    public DateTime DataDeRecebimento { get; private set; } = DateTime.Now;
    public DateTime DataDeAlteracao { get; private set; } = DateTime.Now;


    public AProductModel(Guid Id, Double Valor, String SetorDoProduto, DateTime ValidadeDoProduto,
        DateTime DataDeRecebimento, String NomeDoProduto, String ResponsavelPelaBuscaDoProduto,
        DateTime DataDeAlteracao, String NotaFiscal)
    {
        this.Id = Id;
        this.Valor = Valor;
        this.SetorDoProduto = SetorDoProduto;
        this.ValidadeDoProduto = ValidadeDoProduto;
        this.DataDeRecebimento = DataDeRecebimento;
        this.NomeDoProduto = NomeDoProduto;
        this.ResponsavelPelaBuscaDoProduto = ResponsavelPelaBuscaDoProduto;
        this.DataDeAlteracao = DataDeAlteracao;
        this.NotaFiscal = NotaFiscal;
    }
}
