namespace AtriaFlowDesk.Dominio;

public class Assinante
{
    #region Propriedades relativas ao cadastro na plataforma
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public DateTime DataDeCadastro { get; set; }
    public DateTime DataDeExpiracao { get; set; }
    public bool Ativo { get; set; }
    #endregion
    
    #region Informações sobre o estabelecimento
    //TODO: Criar template para preenchimento das informações sobre o estabelecimento
    //TODO: Quebrar em mais campos: NomeDaEmpresa, Cpf/Cnpj, Endereco (Logradouro, Numero, Complemento, PontoDeReferencia, Bairro, Cidade, Estado, Cep, Coordenadas do Google Maps, Localização no WhatsApp), DataDeFundacao, PerfilNoInstagram, Email, Telefone, TelefoneParaEmergencias (talvez um objeto de valor?)
    public string InformacoesSobreOEstabelecimento { get; set; }  
    #endregion

    #region Informações sobre o profissional
    //TODO: Criar template para preenchimento das informações sobre o profissional
    //TODO: Quebrar em mais campos: NumeroDeRegistroNoConselhoRegional, ApresentacaoProfissional, TelefoneParaEmergencias, EspecialidadePrincipal, OutrasEspecialidades, FormacaoAcademica, ExperienciaProfissional, CertificacoesEAssociacoes, FilosofiaDeAtendimento, DiferenciaisDoProfissional, PerfilNoInstagram, TempoDeExperiencia
    public string InformacoesSobreOProfissional { get; set; }
    #endregion

    #region Informações sobre dias e horários de funcionamento
    //TODO: Criar template para preenchimento das informações sobre o funcionamento
    //TODO: Quebrar em mais campos: DiasDaSemana (checkboxes), HorarioDeAbertura, HorarioDeFechamento, AtendeNosFeriados, Observações (não iremos atender no próximo dia 14 de outubro de 2025, por exemplo) (no próximo dia 22 iremos atender em regime de plantão, por exemplo) (atendemos apenas com hora marcada) (no dia 22 atenderemos até as 14 horas, por exemplo)
    public string InformacoesSobreDiasEHorariosDeFuncionamento { get; set; }
    #endregion

    #region Informações sobre atendimentos
    //TODO: Criar template para preenchimento das informações sobre atendimentos
    //TODO: Quebrar em mais campos: DuracaoDoAtendimentoEmMinutos, ValorDoAtendimentoEmReais, IntervaloEntreAtendimentosEmDias, Garantia, PoliticaDeReembolso
    public string InformacoesSobreAtendimentos { get; set; }
    #endregion

    #region Informações sobre a primeira consulta
    //TODO: Criar template para preenchimento das informações sobre
    //TODO: Quebrar em mais campos: DuracaoDaPrimeiraConsultaEmMinutos, PrimeiraConsultaEhCobrada, ValorDaPrimeiraConsultaEmReais, ValorDaPrimeiraConsultaDescontadoEmCasoDeFechamento, GratuidadeDaPrimeiraConsultaAteAData
    public string InformacoesSobreAPrimeiraConsulta { get; set; }
    #endregion
    
    #region Informações sobre pagamento
    //TODO: Quebrar em mais campos: AceitaConvenios, ConveniosAceitos, FormasDePagamentoAceitas (com juros, sem juros), parcelamento
    public string InformacoesSobrePagamento { get; set; }
    #endregion

    #region Informações sobre agendamento
    //TODO: Implementar recurso de agendamento próprio ou integração com Google Calendar, Outlook, etc.
    #endregion

    #region Informações sobre serviços prestados
    //TODO: Criar template para preenchimento das informações sobre serviços prestados
    //TODO: Quebrar em mais campos: Descricao, Media de valores, IntervaloEntreConsultasEmDias
    public string InformacoesSobreServiçosPrestados { get; set; }
    #endregion

    #region Informações sobre cancelamentos e reagendamentos
    //TODO: Quebrar em mais campos: PoliticaDeCancelamentoEReagendamento, PrazoParaCancelamentoEReagendamento, TaxaDeCancelamentoEReagendamento
    public string InformacoesSobreCancelamentosEReagendamentos { get; set; }
    #endregion

    #region Informações sobre a secretária virtual
    //TODO: Quebrar em mais campos: Nome, Personagem, Personalidade, Foto, Voz, MensagemAutomaticaDeBoasVindas, MensagemAutomaticaDeConfirmacaoDeAgendamento, MensagemAutomaticaDeLembreteDeConsulta
    //TODO: Incluir opções de customização de nome semelhante a personalização do ChatGPT
    //TODO: Incluir opções de customização de voz, semelhante a personalização do ChatGPT
    //TODO: Incluir opções de customização de foto, semelhante a personalização do ChatGPT
    //TODO: Incluir opções de customização de personalidade, semelhante a personalização do ChatGPT
    //TODO: Incluir opções de customização de personagem, semelhante a personalização do ChatGPT
    public string InformacoesSobreASecretariaVirtual { get; set; }
    #endregion

    #region Informações sobre integração com o whatsapp
    //TODO: Quebrar em mais campos: NumeroDeTelefone 
    public string InformacoesSobreIntegracaoComOWhatsApp { get; set; }
    #endregion

    public Assinante()
    {
        Id = Guid.NewGuid();
        DataDeCadastro = DateTime.UtcNow;
    }
}
