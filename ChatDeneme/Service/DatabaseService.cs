using System;
using System.Collections.Generic;
using ChatDeneme.Models;
using ChatDeneme.Models.Settings;
using MongoDB.Driver;

namespace ChatDeneme.Service
{
    public class DatabaseService
    {
        private readonly IMongoCollection<ChatInfoModel> _chatCollection;

        public DatabaseService(IChatDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _chatCollection = database.GetCollection<ChatInfoModel>(settings.ChatCollectionName);
        }

        public bool Write(ChatInfoModel model)
        {
            bool stat = false;
            try
            {
                _chatCollection.InsertOne(model);
                stat = true;
            }
            catch (Exception e)
            {
                /* database loglama işleri yapılmalı. */ 
            }

            return stat;

        }
    }
}