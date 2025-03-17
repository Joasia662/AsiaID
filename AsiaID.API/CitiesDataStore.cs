using AsiaID.API.Models;

namespace AsiaID.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        //singleton pattern at work
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore()
        {

            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Cracow",
                    Description = "Dragon lived here",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Zamek Królewski na Wawelu",
                            Description = "Historyczna rezydencja królów Polski, symbol polskiej państwowości."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Rynek Główny",
                            Description = "Największy średniowieczny rynek w Europie, otoczony zabytkowymi kamienicami i Sukiennicami."
                        }
                    }
                },
                 new CityDto()
                {
                    Id = 2,
                    Name = "Warsaw",
                    Description = "This is the capital",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Stare Miasto",
                            Description = "Historyczne centrum Warszawy, odbudowane po II wojnie światowej, wpisane na listę UNESCO."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Łazienki Królewskie",
                            Description = "Zespół pałacowo-parkowy z XVIII wieku, popularne miejsce wypoczynku mieszkańców i turystów."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Poznan",
                    Description = "Rogale yummy yummy",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Stary Rynek",
                            Description = "Centralny plac miasta z kolorowymi kamienicami i renesansowym ratuszem."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Ostrów Tumski",
                            Description = "Najstarsza część Poznania z katedrą, gdzie pochowani są pierwsi władcy Polski."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 4,
                    Name = "Wroclaw",
                    Description = "Miasto mostów",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Rynek we Wrocławiu",
                            Description = "Jeden z największych rynków w Europie, otoczony kolorowymi kamienicami."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Ostrów Tumski",
                            Description = "Najstarsza część miasta z katedrą św. Jana Chrzciciela."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 5,
                    Name = "Gdansk",
                    Description = "Perła Bałtyku",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Długi Targ",
                            Description = "Reprezentacyjna ulica miasta z Fontanną Neptuna i Ratuszem Głównego Miasta."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Żuraw",
                            Description = "Dawny dźwig portowy, symbol handlowej potęgi Gdańska."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 6,
                    Name = "Lodz",
                    Description = "Polski Manchester",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Ulica Piotrkowska",
                            Description = "Jedna z najdłuższych ulic handlowych w Europie, serce miasta."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Manufaktura",
                            Description = "Centrum kulturalno-handlowe w zrewitalizowanych budynkach fabrycznych."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 7,
                    Name = "Lublin",
                    Description = "Miasto inspiracji",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Zamek Lubelski",
                            Description = "Średniowieczny zamek z Kaplicą Trójcy Świętej z unikalnymi freskami."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Stare Miasto",
                            Description = "Zabytkowa część miasta z renesansowymi kamienicami i Bramą Krakowską."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 8,
                    Name = "Szczecin",
                    Description = "Paryż Północy",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Zamek Książąt Pomorskich",
                            Description = "Renesansowy zamek będący siedzibą książąt pomorskich."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Wały Chrobrego",
                            Description = "Tarasy widokowe nad Odrą z imponującą architekturą."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 9,
                    Name = "Bydgoszcz",
                    Description = "Mała Wenecja",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Wyspa Młyńska",
                            Description = "Zielona oaza w centrum miasta otoczona wodami Brdy."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Opera Nova",
                            Description = "Nowoczesny gmach opery położony nad rzeką."
                        }
                    }
                }
            };
        }
    }
}
