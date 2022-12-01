using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PowerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerApp.ViewModels
{
    public partial class TipsViewModel : BaseViewModel
    {
        [ObservableProperty]
        private List<Tip> list;

        public TipsViewModel()
        {
            List = new List<Tip>() {
                new Tip()
                {
                    Title = "1. Kies voor een klein spaardoel:",
                    Text = "Het is nou eenmaal makkelijker om een klein spaardoel te bereiken dan een groot spaardoel. Een maand lang twintig euro per week sparen is stukken makkelijker dan een jaar lang tweehonderd euro per week willen sparen. Heb je al een groot spaardoel in gedachten? Probeer dat doel dan op te splitsen in kleinere doelen, of begin eerst met een lagere stap. Verkort de periode (een maand lang sparen in plaats van een jaar) en verlaag het bedrag (twintig per week in plaats van tweehonderd per week). Zodra je dat voor elkaar hebt kun je je spaarbedrag weer wat verhogen. Heb je nog geen idee waar je voor wilt gaan sparen? Bekijk hier 7 voorbeelden van financiële doelen (en 3 tips om ze te bereiken).",
                    Image = null
                },
                new Tip()
                {
                    Title = "2. Geef een naam aan je spaarrekening:",
                    Text = "Één van m’n favoriete spaartips! Waarom? “Spaarrekening” op zich zegt niet zoveel. Eigenlijk maar gewoon wat getallen op je bankrekening. Maar een spaarrekening met de naam “Vakantie Bali” zegt dan wel weer een hoop.",
                    Image = "picture1.png"
                },
                new Tip()
                {
                    Title = "3. Maak verschillende potjes aan:",
                    Text = "Heb je meerdere spaardoelen? Maak dan aparte potjes aan. Bij de meeste banken kan dat tegenwoordig heel gemakkelijk (en kosteloos) via de app of internetbankieren.\r\n\r\n Zelf heb ik nu onder andere potjes genaamd Jaarlijkse belastingen, Zorgverzekering (m’n zorgverzekering betaal ik jaarlijks in één keer, maar leg wel elke maand geld apart op deze spaarrekening) en Eigen risico.",
                    Image = null
                },
                new Tip()
                {
                    Title = "4. Spaar een vast bedrag:",
                    Text = "Spaar je op dit moment gewoon wat er maandelijks overblijft? Door een vast bedrag per maand te sparen draai je dat eigenlijk om; je spaart eerst en gaat daarna pas uitgeven. Maar hoeveel kan je per maand sparen? Om daar achter te komen is het handig om een paar maanden je uitgaven bij te houden, zo weet je precies wat er maandelijks overblijft. Als je elke maand dan een bedrag spaart wat nét wat meer is dan wat er de afgelopen maanden is overgebleven, push je jezelf om maandelijks meer te sparen.",
                    Image = "picture1.png"
                },
                new Tip()
                {
                    Title = "5. Spaar meteen wanneer je je inkomsten binnenkrijgt",
                    Text = "Spaarrekening zodra er inkomsten binnenkomen. Krijg je je salaris gestort? Verplaats de komma in het bedrag één plek naar links en maak dat bedrag over naar je spaarrekening. Door hier een gewoonte van te maken betaal je jezelf eerst, voordat je andere uitgaven gaat doen.",
                    Image = "null"
                }
            };
        }


    }
}
