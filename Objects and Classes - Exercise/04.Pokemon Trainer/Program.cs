using System;
using System.Collections.Generic;
using System.Linq;

public class Trainer
{
    public string Name { get; set; }
    public int Badges { get; set; }
    public List<Pokemon> PokemonCollection { get; }

    public Trainer(string name)
    {
        Name = name;
        Badges = 0;
        PokemonCollection = new List<Pokemon>();
    }

    public void AddPokemon(Pokemon pokemon)
    {
        PokemonCollection.Add(pokemon);
    }

    public void RemovePokemon(Pokemon pokemon)
    {
        PokemonCollection.Remove(pokemon);
    }
}

public class Pokemon
{
    public string Name { get; set; }
    public string Element { get; set; }
    public int Health { get; set; }

    public Pokemon(string name, string element, int health)
    {
        Name = name;
        Element = element;
        Health = health;
    }
}

class Program
{
    static void Main()
    {
        Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

        string input;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            string[] tokens = input.Split();
            string trainerName = tokens[0];
            string pokemonName = tokens[1];
            string pokemonElement = tokens[2];
            int pokemonHealth = int.Parse(tokens[3]);

            Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

            if (!trainers.ContainsKey(trainerName))
            {
                trainers[trainerName] = new Trainer(trainerName);
            }

            trainers[trainerName].AddPokemon(pokemon);
        }

        while ((input = Console.ReadLine()) != "End")
        {
            string element = input;

            foreach (var trainer in trainers.Values)
            {
                if (trainer.PokemonCollection.Any(p => p.Element == element))
                {
                    trainer.Badges++;
                }
                else
                {
                    foreach (var pokemon in trainer.PokemonCollection.ToList())
                    {
                        pokemon.Health -= 10;
                        if (pokemon.Health <= 0)
                        {
                            trainer.RemovePokemon(pokemon);
                        }
                    }
                }
            }
        }

        foreach (var trainer in trainers.OrderByDescending(t => t.Value.Badges))
        {
            Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.PokemonCollection.Count}");
        }
    }
}