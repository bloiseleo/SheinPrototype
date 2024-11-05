using Microsoft.EntityFrameworkCore;
using SheinPrototype.Models;

namespace SheinPrototype.Context;

public class DbInitialize
{
    private Dictionary<string, Func<Category, List<Product>>> _products = new()
    {
        {"Roupa Masculina", (category) => new List<Product>()
        {
            new Product()
            {
                Name = "Camiseta Masculina Boss Camisa Malha de Algodão",
                Description = "Camiseta Masculina Boss Camisa Malha de Algodão",
                Category = category,
                Price = 26.90m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "wine",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/06/27/cf/1719456830970c55f33562723918e7763d04203b7f_thumbnail_750x999.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/06/27/bc/171945680642414488a1cd9b8310721487e4e9694a_thumbnail_750x999.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/06/27/81/1719456820fe1eaf6c4d4c5f943fd68a69a51e7c75_thumbnail_750x999.webp"
                    }
                }
            },
            new Product()
            {
                Name = "Camisa florida havaiana floral masculina estampada viscose manga curta",
                Description = "Camisa florida havaiana floral masculina estampada viscose manga curta",
                Category = category,
                Price = 34.99m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/07/28/03/17221760562c3d384c3982ae01571afdb24d4eceb9_thumbnail_750x999.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/07/28/92/1722176395120b551888f9336e7fd59442af85141e_thumbnail_750x999.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Calça de SARJA Masculina Alfaiataria Social Sport Fino Slim",
                Description = "Calça de SARJA Masculina Alfaiataria Social Sport Fino Slim",
                Category = category,
                Price = 70.90m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/05/23/f9/1716465099e00b42ea91d93420f521d714b36dd030_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "brown",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/05/23/8f/171646600317159600ab17477c104b5e9d82b22626_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Conjunto Bermuda Tactel+ Camiseta 100% Algodão Nova Estampa WHATEVER Material Alta Qualidade Masculino",
                Description = "Conjunto Bermuda Tactel+ Camiseta 100% Algodão Nova Estampa WHATEVER Material Alta Qualidade Masculino",
                Category = category,
                Price = 54.90m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/10/01/13/17277944197b34bf81c9f05631c6ad6c3a7d8aed20_square_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/10/01/a8/1727794414edd26977bd2522356edac24a029971e8_square_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Bermuda Jeans Rasgada Shorts Cor Escuro Masculinos Alta Qualidade Com Elastano Sport Loja de Fábrica",
                Description = "Bermuda Jeans Rasgada Shorts Cor Escuro Masculinos Alta Qualidade Com Elastano Sport Loja de Fábrica",
                Category = category,
                Price = 34.88m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "jeans",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/10/14/df/17288774722686b23a17972f8fdcb5ce683fa130bd_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Camiseta Masculina Algodão Adulto Plus Size Infantil Astronauta Balance Sorrisso Halloween Sad Over Streetwear",
                Description = "Camiseta Masculina Algodão Adulto Plus Size Infantil Astronauta Balance Sorrisso Halloween Sad Over Streetwear",
                Category = category,
                Price = 25.98m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/09/21/f8/17268520427294b660e0810f2f3beea88fa05eb429_thumbnail_900x.jpg"
                    },
                }
            },
            new Product()
            {
                Name = "Camiseta Masculina básica paris casual Estampada T-shirt camisa",
                Description = "Camiseta Masculina básica paris casual Estampada T-shirt camisa",
                Category = category,
                Price = 13.04m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/06/27/6a/1719487690531cb6448cde7a5704a3bb50aba5010d_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Camiseta Masculina Cruz Dupla Religião Cristão 100% Algodão Promoção Malha Premium Fio 30.1",
                Description = "Camiseta Masculina Cruz Dupla Religião Cristão 100% Algodão Promoção Malha Premium Fio 30.1",
                Category = category,
                Price = 29.30m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/08/30/d3/17250313779bcea081290b2d5a715b244a2c1f14b5_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/08/30/e1/1725031385e69784efdc04554c8baa062e69de4f3c_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Camisa Conjunto listrada e lisa masculina slim fite Manga curta viscose",
                Description = "Camisa Conjunto listrada e lisa masculina slim fite Manga curta viscose",
                Category = category,
                Price = 69.99m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/06/11/bb/17180659117f3f5bf965212dc97f9c584ec98d7cef_thumbnail_900x.jpg"
                    },
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/06/11/c7/17180660388a8cf6977a060c8e9e3ef2cfd880c329_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Camiseta masculina Los angeles Casual basica 100% algodao Premium",
                Description = "Camiseta masculina Los angeles Casual basica 100% algodao Premium",
                Category = category,
                Price = 19.90m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/07/10/ec/1720557784568fb0017cb2e2a6de42fca9b9045343_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/07/10/af/17205577958f471084b3f127cb8b65004199f3820d_thumbnail_336x.webp"
                    },
                }
            }
        }},
        {"Infantil", (category) => new List<Product>()
        {
            new Product()
            {
                Name = "Camiseta de manga curta básica para meninos pequenos com estampa casual de boneco de neve e Papai Noel para o Natal",
                Description = "Camiseta de manga curta básica para meninos pequenos com estampa casual de boneco de neve e Papai Noel para o Natal",
                Category = category,
                Price = 25.90m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/10/03/2a/1727964211b1d9b2efac85597a26f51b7bc75451d7_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Calça Jeans Wide Leg Destroyed Desenho Borboleta Infantil Menina",
                Description = "Calça Jeans Wide Leg Destroyed Desenho Borboleta Infantil Menina",
                Category = category,
                Price = 49.99m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/05/04/4a/171476474521cb689020270398dce1951c485b3f37_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "CONJUNTO LELELI SUBLIMADO SAIA FASHION/ MENINAS BLOGUERINHA LANÇAMENTO/ MENINAS MINI DIVAS",
                Description = "CONJUNTO LELELI SUBLIMADO SAIA FASHION/ MENINAS BLOGUERINHA LANÇAMENTO/ MENINAS MINI DIVAS",
                Category = category,
                Price = 42.99m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/10/04/46/1727975696c9a5d4716f6a92d3eec13792bd2a9d35_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Calça Jogger Infantil Jeans Sarja Juvenil Criança",
                Description = "Calça Jogger Infantil Jeans Sarja Juvenil Criança",
                Category = category,
                Price = 54.99m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/05/10/ab/17152815640a568cf2a0a4db1415afef82be877c87_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/05/10/97/171528151508335fb2fd87541523cb551461eb742e_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Blusa Cropped de Brilho feminina ribana infantil Juvenil modinha verão mini diva Blogueirinha 2 a 14",
                Description = "Blusa Cropped de Brilho feminina ribana infantil Juvenil modinha verão mini diva Blogueirinha 2 a 14",
                Category = category,
                Price = 34.90m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/07/11/5f/1720708395b1ba8e4646b10ab246e4fa1b6aead329_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/07/11/be/1720708429f87ed8d1da906accb88ebc51697996a8_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "pink",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/07/11/0c/1720708103af39469cfbced584c780599177edf312_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Camiseta Infantil e Juvenil Dry Esportiva Meninos Time de Futebol",
                Description = "Camiseta Infantil e Juvenil Dry Esportiva Meninos Time de Futebol",
                Category = category,
                Price = 44.90m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/10/17/5b/17291002224cd6ad4d64bee3d1fc4aed23e1407182_square_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Vestido infantil menina modelo três maria ROXO E BRANCO",
                Description = "Vestido infantil menina modelo três maria ROXO E BRANCO",
                Category = category,
                Price = 19.16m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/06/15/f1/171838928088650c2ac22d8f0f83d56ccda49f18ca_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Conjunto verão menino infantil juvenil novidade kit de bermuda e camisa do 2 ao 12 anos lançamento original",
                Description = "Conjunto verão menino infantil juvenil novidade kit de bermuda e camisa do 2 ao 12 anos lançamento original",
                Category = category,
                Price = 19.16m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/02/20/37/17083653606fccc5b3904e06131b028aa185c07b0d_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Vestido infantil menina estampa colorida feminino rodado casual festa",
                Description = "Vestido infantil menina estampa colorida feminino rodado casual festa",
                Category = category,
                Price = 34.90m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/02/28/dd/17090565332d6dd5701b168b96bfb256d66c0aaf5a_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Conjunto Infantil Verão Masculino Recortes Explore - Verde",
                Description = "Conjunto Infantil Verão Masculino Recortes Explore - Verde",
                Category = category,
                Price = 25.42m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/08/30/a0/17249645053454b6eaee63d34c49cd84331c98d0d2_thumbnail_900x.jpg"
                    },
                }
            }
        } },
        {"Roupa Feminina", (category) => new List<Product>()
        {
            new Product()
            {
                Name = "Denim Femininos, Botão Feminino, Zíper, Cintura Alta, Perna Flare, Lavagem Média Longa em Algodão Folgado, Denim Femininos, Primavera/Outono, Uso Casual Diário",
                Description = "Denim Femininos, Botão Feminino, Zíper, Cintura Alta, Perna Flare, Lavagem Média Longa em Algodão Folgado, Denim Femininos, Primavera/Outono, Uso Casual Diário",
                Category = category,
                Price = 62.99m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2023/11/01/b0/16988453162cd0c43367dc7f2b4bab155beccbc841_thumbnail_900x.jpg"
                    },
                }
            },
            new Product()
            {
                Name = "KIT 3 BODY SUPLEX DECOTE QUADRADO COM FORRO REGATA",
                Description = "KIT 3 BODY SUPLEX DECOTE QUADRADO COM FORRO REGATA",
                Category = category,
                Price = 50.99m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/08/16/a6/1723748741616e4488f2b6ae10278e194ae9f57085_square_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "BOBY FEMININO GOLA ALTA REGATA \\ COM FECHO",
                Description = "BOBY FEMININO GOLA ALTA REGATA \\ COM FECHO",
                Category = category,
                Price = 26.99m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2023/09/17/26/169493194907d03eccaaf2fcfc8263a8fbf9ba9d1e_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "blue",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2023/09/17/20/16949320378f1123e52ba440e9e7154264af5fc28e_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "green",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2023/09/17/1e/16949319893ec46f1c60875dbbedac0c83bdf51865_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Conjunto feminino duna areia calça pantalona e cropped com bojo Alça regulagem alfaiataria",
                Description = "Conjunto feminino duna areia calça pantalona e cropped com bojo Alça regulagem alfaiataria",
                Category = category,
                Price = 69.00m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2023/12/13/d0/1702431642dfc013226a30779484dcbf60a88813a7_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "blue",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/01/16/c4/1705412616aaca19b6bcd3788386de4f1c3a018336_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "green",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2023/12/13/03/17024319046847b7eb96e66eb3275abb7d410e39b6_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "SHEIN Holidaya Vestido de Costas Abertas de Cor Sólida com Textura, Ideal para Férias de Verão",
                Description = "SHEIN Holidaya Vestido de Costas Abertas de Cor Sólida com Textura, Ideal para Férias de Verão",
                Category = category,
                Price = 68.61m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2024/07/15/8e/17210235337dca786fcb849f27119c6816ff13a056_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "pink",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2024/04/23/d0/17138432155e938d9db3d33c46d4b6b7d3d6b0b27e_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "red",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2024/08/12/b7/1723456520ccf23c37a49266720cad9986989e19f8_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Short cargo feminino moletinho verão",
                Description = "Short cargo feminino moletinho verão",
                Category = category,
                Price = 38.99m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "green",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/06/26/ba/17193688765a7d35711aeee39caba49600d6030c84_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/06/26/6c/1719369051451e4c4f6f18eb67f9446c0c8016ea1f_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Calça Feminina Alfaiataria Com Cinto tendencia 2024",
                Description = "Calça Feminina Alfaiataria Com Cinto tendencia 2024",
                Category = category,
                Price = 39.97m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/04/08/81/1712537101dc1cda3a4c48af0bc94411c7ddfdee4d_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/09/11/fb/172602561365597a89bda2785e0094c3bb88a5678f_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Vestido feminino alça fina curto",
                Description = "Vestido feminino alça fina curto",
                Category = category,
                Price = 24.00m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/09/27/f5/172737549767f80d8c29af87d054a7bb521b428ac4_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "red",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/09/27/f9/1727375841aa54443a71545ea7d278f9a28854dcbf_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "SHEIN TaskFit Conjunto Uniforme Casual com Top Minimalista de Gola Careca e Calça de Moletom com Bolso",
                Description = "SHEIN TaskFit Conjunto Uniforme Casual com Top Minimalista de Gola Careca e Calça de Moletom com Bolso",
                Category = category,
                Price = 103.66m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2024/09/24/c9/1727141544a6f947654c5dc2aeeb80210259a3cb37_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Vestido alcinha comprida listrado",
                Description = "Vestido alcinha comprida listrado",
                Category = category,
                Price = 49.00m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "//img.ltwebstatic.com/images3_spmp/2024/08/21/29/1724252184b9be826f5b1adafea47e1ad506989f52_thumbnail_336x.webp"
                    },
                }
            },
        }},
        {"Beleza", (category) => new List<Product>()
        {
            new Product()
            {
                Name = "Kit 12 Esponjas para Maquiagem Multifuncional 024-146",
                Description = "Kit 12 Esponjas para Maquiagem Multifuncional 024-146",
                Category = category,
                Price = 13.52m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "pink",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/09/25/ea/17272024357597e0c42d7e6e60fd242841d2261978_square_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/09/25/00/1727202448854fc7c170b21628ec0e3650cb982e60_square_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Creme Firmador De Bumbum Gel Massageador Para Celulite Estria Flacidez Queimador de Gorduras",
                Description = "Creme Firmador De Bumbum Gel Massageador Para Celulite Estria Flacidez Queimador de Gorduras",
                Category = category,
                Price = 12.49m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "pink",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2023/11/23/32/1700751334491a0dc4fa9aad0a8f0d3fad52f3ab32_square_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Produto Cresce Cabelo Barba e Sobrancelha Tonico Capilar 30ml",
                Description = "Produto Cresce Cabelo Barba e Sobrancelha Tonico Capilar 30ml",
                Category = category,
                Price = 20.69m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/07/29/9f/1722257839e3c03cd13bbb538af09620869d105580_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Depilador Batom Portátil Facial Buço Rosto Aparador Pelos USB",
                Description = "Depilador Batom Portátil Facial Buço Rosto Aparador Pelos USB",
                Category = category,
                Price = 16.99m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "default",
                        ImageUrl = "//img.ltwebstatic.com/gspCenter/goodsImage/2022/7/29/3560875357_1013148/249F6526ACC78E04832A7E03E2F1326C_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Kit Melancia (Sabonete Líquido + Hidratante) Experiência Frutal Em Aromas Exclusivos Para Cuidados Diários",
                Description = "Kit Melancia (Sabonete Líquido + Hidratante) Experiência Frutal Em Aromas Exclusivos Para Cuidados Diários",
                Category = category,
                Price = 19.90m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "default",
                        ImageUrl = "//img.ltwebstatic.com/images3_spmp/2024/08/14/e3/17235754698ad30236edb299523eec6939a3af902c_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Delineador De Silicone Reutilizável/Ferramenta De Maquiagem Para Desenho/Batom",
                Description = "Delineador De Silicone Reutilizável/Ferramenta De Maquiagem Para Desenho/Batom",
                Category = category,
                Price = 9.99m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "default",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2023/08/31/5c/1693424336cacd8c60479392cedc39e513b6cfa10e_square_thumbnail_336x.webp"
                    }
                }
            },
            new Product()
            {
                Name = "Removedor Aparador de Pelos Elétrico/Portátil para Nariz/Orelha/Rosto / Depilador Facial",
                Description = "Removedor Aparador de Pelos Elétrico/Portátil para Nariz/Orelha/Rosto / Depilador Facial",
                Category = category,
                Price = 14.99m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "default",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/07/05/a4/172018586349569690c646bf1ec8a8c09cd6932ba6_square_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Kit 3 Esponjas Para Maquiagem",
                Description = "Kit 3 Esponjas Para Maquiagem",
                Category = category,
                Price = 9.80m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "default",
                        ImageUrl = "https://img.ltwebstatic.com/gspCenter/goodsImage/2023/3/23/9428230732_1059426/CE59893215C14C722C5A18CA67F81455_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Parafina Bronzeadora Acelerador Summer Bronze Bel Veg 150g",
                Description = "Parafina Bronzeadora Acelerador Summer Bronze Bel Veg 150g",
                Category = category,
                Price = 17.80m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "default",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/03/08/01/170987135651802ec7d36b2bdee87423a03f15b1ea_square_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Ba Ba BaLLoperfume capilar",
                Description = "Ba Ba BaLLoperfume capilar",
                Category = category,
                Price = 18.69m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "default",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/08/08/ea/17230487008f593a9097e7a3c7d6141a3524e9ca8c_thumbnail_336x.webp"
                    },
                }
            },
        }},
        {"Roupa de Praia", (category) => new List<Product>()
        {
            new Product()
            {
                Name = "SHEIN Swim Maiô Sexy Feminino de Uma Peça com Decote Quadrado, Cor Sólida de Verão, Vazado nas Costas e sem Alças para Praia",
                Description = "SHEIN Swim Maiô Sexy Feminino de Uma Peça com Decote Quadrado, Cor Sólida de Verão, Vazado nas Costas e sem Alças para Praia",
                Category = category,
                Price = 39.38m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2024/05/10/7c/1715313855bca5e27449ec5100cc3bc1450810a620_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "red",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2024/05/09/04/1715242360606e81e94114b3ae1ddc49564f811b03_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2024/06/10/f2/171794896994514797b9f72d59f822556fecf4b22c_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Saída de Praia Calça Feminina Tricot Crochê para Biquini de Praia",
                Description = "Saída de Praia Calça Feminina Tricot Crochê para Biquini de Praia",
                Category = category,
                Price = 25.80m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2023/12/27/09/1703685249302e7f61893b5db0c4e8a0b3d2d3d28f_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "pink",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2023/12/27/8e/17036862993e55ad71c30eeea3f2deebb88d50a03b_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "brown",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/02/06/b0/17071608199694a5dceee89018a728596cb33a0571_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "Cobertura de férias casual sem mangas em cor sólida para mulheres",
                Description = "Cobertura de férias casual sem mangas em cor sólida para mulheres",
                Category = category,
                Price = 59.90m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2024/04/08/bb/17125832156f7a535f0bb58c88772740238b82b85f_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "blue",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2024/06/06/79/17176613454848399d0777259362248c631618a214_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "green",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2024/06/06/19/17176611218e74ae422bf7a9ccedaa45a5a25b4b02_thumbnail_336x.webp"
                    }
                }
            },
            new Product()
            {
                Name = "Gina Biquíni Asa Delta Com Bojo Conjunto Calcinha e Sutiã Varias Cores",
                Description = "Gina Biquíni Asa Delta Com Bojo Conjunto Calcinha e Sutiã Varias Cores",
                Category = category,
                Price = 22.99m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "blue",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/08/15/e3/1723658842428922d53fe8362e9ea152d08659ccc5_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "SHEIN Swim Dividido Tie Dye Sensual Boho Conjunto de biquíni",
                Description = "SHEIN Swim Dividido Tie Dye Sensual Boho Conjunto de biquíni",
                Category = category,
                Price = 79.82m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2024/02/19/dd/1708333218a620578f4cf4554000d74cfeb081a5ab_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "pink",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2024/06/17/8f/17185877181676a6f106884fff6095ed1ee6e85258_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2023/07/03/168836756453495743644e8e1b0b566bce1279e1ff_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "SHEIN Swim Top de Biquíni",
                Description = "SHEIN Swim Top de Biquíni",
                Category = category,
                Price = 40.95m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2022/07/15/1657853841ecf982ffe235a69bcaa7ce4cd9f2fd71_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2024/02/27/dc/170900037476446223660d8b510c0fd1abfb6fc2dd_thumbnail_336x.webp"
                    }
                }
            },
            new Product()
            {
                Name = "SHEIN Swim Conjunto de Maiô Bikini Estampa Tropical de Praia de Verão com Sutiã Halter e Short Boxer, 2 Peças",
                Description = "SHEIN Swim Conjunto de Maiô Bikini Estampa Tropical de Praia de Verão com Sutiã Halter e Short Boxer, 2 Peças",
                Category = category,
                Price = 55.21m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "white",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2022/09/13/1663040805a4fd022b8cde233b129b8101c06b7edb_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "blue",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2023/05/26/16850873553003bb989a176aa88d94c7adcb3ec2a9_thumbnail_336x.webp"
                    }
                }
            },
            new Product()
            {
                Name = "Short biquíni feminino de banho Shortinho Sunkini Short Sunquini franzido lateral C elastano, P.M.G.GG",
                Description = "Short biquíni feminino de banho Shortinho Sunkini Short Sunquini franzido lateral C elastano, P.M.G.GG",
                Category = category,
                Price = 19.96m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "black",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/10/02/97/1727849146554eb082b1331b792dcb462414bf3e13_square_thumbnail_336x.webp"
                    },
                    new ProductVariations()
                    {
                        Color = "red",
                        ImageUrl = "https://img.ltwebstatic.com/images3_spmp/2024/09/15/b2/1726356364a42cf34cd838dd7d087d009681cd633f_square_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "SHEIN Swim Plantar & Impressão Floral Tankini Set Manga Comprida Costura Nadar Camiseta & Amarração Frontal Shorts Golfinho 2 Peças Roupa De Banho",
                Description = "SHEIN Swim Plantar & Impressão Floral Tankini Set Manga Comprida Costura Nadar Camiseta & Amarração Frontal Shorts Golfinho 2 Peças Roupa De Banho",
                Category = category,
                Price = 78.19m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "pink",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2023/05/17/168430103157f8ab4775b011633988c3338a320f10_thumbnail_336x.webp"
                    },
                }
            },
            new Product()
            {
                Name = "SHEIN Swim Conjunto de Bikini feminino floral de 3 peças para verão na praia",
                Description = "SHEIN Swim Conjunto de Bikini feminino floral de 3 peças para verão na praia",
                Category = category,
                Price = 83.22m,
                Variations = new List<ProductVariations>()
                {
                    new ProductVariations()
                    {
                        Color = "blue",
                        ImageUrl = "https://img.ltwebstatic.com/images3_pi/2024/02/01/76/170678256229ef3114624fa394e8c70cd36a772127_thumbnail_336x.webp"
                    },
                }
            },
        }}
    };
    private List<List<string>> _categories = new()
    {
        new List<string>(){"Roupa Masculina", "https://img.ltwebstatic.com/images3_abc/2024/10/28/b8/17301215137adcaff8dce2ec3b3ff80538e93c6cec.png"},
        new List<string>(){"Roupa Feminina", "https://img.ltwebstatic.com/images3_abc/2024/10/23/b1/17296851938759a0411142012e0c55befcdbab65b3.png"},
        new List<string>() {"Infantil", "https://img.ltwebstatic.com/images3_abc/2024/10/28/a5/1730119535701fe7f020eeb685da50b06cabc0c3b3.png"},
        new List<string>() { "Beleza", "https://img.ltwebstatic.com/images3_ccc/2023/11/01/49/1698820341987642e480964f1e2d66a350889c704e.jpg"},
        new List<string>() {"Roupa de Praia", "https://img.ltwebstatic.com/images3_abc/2024/04/08/9d/1712578411d271228d70c0218ad2a46c7a3e735013.png"}
    };
    private SheinContext _context;
    private ILogger<DbInitialize> _logger;
    private DbContextOptions<SheinContext> _options;
    public DbInitialize(SheinContext context, ILogger<DbInitialize> logger, DbContextOptions<SheinContext> options)
    {
        _context = context;
        _logger = logger;
        _options = options;
    }
    
    private void initializeCategories()
    {
        _logger.LogInformation("Verfying if Seeding categories is needed...");
        _context.Database.EnsureCreated();
        if (_context.Categories.Any())
        {
            _logger.LogInformation("Database already seeded");
            return;
        }
        _logger.LogInformation("Seeding categories");
        var categories = _categories.Select(d => new Category()
        {
            Name = d[0],
            Url = d[1]
        });
        _context.AddRange(categories);
        _context.SaveChanges();
        _logger.LogInformation("Categories Seeded");
    }

    private void initializeProducts(SheinContext context, string category)
    {
        _logger.LogInformation("Check if products already seeded.");

        if (!_products.ContainsKey(category))
        {
            return;
        }
        if (_context.Products.Where(p => p.Category.Name == category).Any())
        {
            return;
        }
        _logger.LogInformation("Seeding products");
        var productsFactory = _products[category];
        var categoryData = context.Categories.First(c => c.Name == category);
        var products = productsFactory(categoryData);
        context.AddRange(products);
        context.SaveChanges();
    }
    public void Initialize()
    {
        initializeCategories();
        foreach (var category in _categories)
        {
            // Use a new context for each call to initializeProducts
            using (var newContext = new SheinContext(_options))
            {
                initializeProducts(newContext, category[0]);
            }
        }
    }
}