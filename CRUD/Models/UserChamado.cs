public class UserChamado
{
    public int ChamId { get; set; }
    public DateTime ChamData { get; set; }
    public DateTime ChamDataFechamento { get; set; }
    public string ChamDetalhe { get; set; } = string.Empty;
    public string ChamStatus { get; set; } = string.Empty;
    public int AtendenteId { get; set; }
    public int UsuId { get; set; }
    public int CatId { get; set; }
    public int PriId { get; set; }
}
