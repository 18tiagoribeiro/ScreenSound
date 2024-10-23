using OpenAI_API;
using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarBanda : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Registro das bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            Banda banda = new Banda(nomeDaBanda);
            bandasRegistradas.Add(nomeDaBanda, banda);

            var client = new OpenAIAPI("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");

            var chat = client.Chat.CreateConversation();

            chat.AppendSystemMessage($"Faça um resumo da banda/artista {nomeDaBanda} em 1 parágrafo de forma informal");

            string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
            banda.Resumo = resposta;

            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
