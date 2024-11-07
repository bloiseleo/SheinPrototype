using System.Globalization;
using SheinPrototype.Models;
using SheinPrototype.Repositories;
using System.Text;

namespace SheinPrototype.Services;

public class PostCodeService
{
    private readonly PostCodeRepository _postCodeRepository;

    public PostCodeService(PostCodeRepository postCodeRepository)
    {
        _postCodeRepository = postCodeRepository;
    }
    private readonly Dictionary<int, Func<PostCode, TrackViewModel.StatusViewModel>> defaultStatus = new()
    {
        {0, (postCode) =>
        {
            return new TrackViewModel.StatusViewModel()
            {
                Day = postCode.StartDate.ToString("D", new CultureInfo("pt-BR")).ToUpper(),
                Message = "Produtos em separação"
            };
        }},
        {
            1, (postCode) => new TrackViewModel.StatusViewModel()
            {
                Day = postCode.StartDate.AddDays(5).ToString("D", new CultureInfo("pt-BR")).ToUpper(),
                Message = "O produto foi coletado pela transportadora"
            } 
        },
        {
            2, (postCode) => new TrackViewModel.StatusViewModel()
            {
                Day = postCode.StartDate.AddDays(5 * 2).ToString("D", new CultureInfo("pt-BR")).ToUpper(),
                Message = "O produto foi recebido nas instalações da transportadora"
            }
        },
        {
            3, (postCode) => new TrackViewModel.StatusViewModel()
            {
                Day = postCode.StartDate.AddDays(5 * 3).ToString("D", new CultureInfo("pt-BR")).ToUpper(),
                Message = "O produto deixou as instalações da transportadora"
            }
        },
        {
            4, (postCode) => new TrackViewModel.StatusViewModel()
            {
                Day = postCode.StartDate.AddDays(5 * 4).ToString("D", new CultureInfo("pt-BR")).ToUpper(),
                Message = "O produto está a caminho de entrega para o cliente"
            }
        },
        {
            5, (postCode) => new TrackViewModel.StatusViewModel()
            {
                Day = postCode.StartDate.AddDays(5 * 5).ToString("D", new CultureInfo("pt-BR")).ToUpper(),
                Message = "Oops! Tivemos um problema com a sua entrega. Uma nova tentativa será realizada em breve"
            }
        },
        {
            6, (postCode) => new TrackViewModel.StatusViewModel()
            {
                Day = postCode.StartDate.AddDays(5 * 6).ToString("D", new CultureInfo("pt-BR")).ToUpper(),
                Message = "Oops! Tivemos um problema com a sua entrega. Entre em contato com o suporte para mais informações. :("
            }
        }
    };

    private string generateTrackingCode()
    {
        Random random = new Random();
        var trackingCode = new StringBuilder();
        trackingCode.Append((char)random.Next('A', 'Z' + 1));
        trackingCode.Append((char)random.Next('A', 'Z' + 1));
        for (int i = 0; i < 9; i++)
        {
            trackingCode.Append(random.Next(0, 10));
        }
        trackingCode.Append((char)random.Next('A', 'Z' + 1));
        trackingCode.Append((char)random.Next('A', 'Z' + 1));
        return trackingCode.ToString();
    }
    public PostCode CreatePostCode(Order order)
    {
        var trackingCode = generateTrackingCode();
        var postCode = new PostCode()
        {
            Order = order,
            Token = trackingCode,
            StartDate = DateTime.Now.ToUniversalTime(),
        };
        return _postCodeRepository.CreatePostCode(postCode);
    }
    public TrackViewModel GetTrackViewModel(PostCode postCode)
    {
        var difference = DateTime.Now - postCode.StartDate;
        var quince = difference.Days / 5;
        var statuses = new List<TrackViewModel.StatusViewModel>();
        for (int i = 0; i < (quince + 1); i++)
        {
            statuses.Add(defaultStatus[i](postCode));
        }
        return new TrackViewModel()
        {
            Token = postCode.Token,
            Status = statuses
        };
    }

    public bool AlreadyHasABuy(string cpf)
    {
        var postCode = _postCodeRepository.FindPostCodeByCpf(cpf);
        return postCode != null;
    }
}