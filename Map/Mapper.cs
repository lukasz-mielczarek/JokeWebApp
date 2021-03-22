using JokeWebApp.Entities;
using JokeWebApp.Models;
using System.Collections.Generic;

namespace JokeWebApp.Map
{

    public static class Mapper
    {
        public static Joke ToEntity(JokeModel model)
        {
            var entity = new Joke
            {
                Id = model.Id,
                joke = model.Joke

            };

            return entity;
        }



        public static JokeModel ToModel(Joke entity)
        {
            var model = new JokeModel
            {
                Id = entity.Id,
                Joke = entity.joke
            };

            return model;
        }
        public static List<JokeModel> ToModelList(List<Joke> entities)
        {
            var list = new List<JokeModel>();
            foreach (var entity in entities)
            {
                list.Add(ToModel(entity));
            }
            return list;
        }


    }
}

