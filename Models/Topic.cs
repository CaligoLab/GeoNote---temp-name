﻿namespace Geonote.Models
{
    public class Topic
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<GeonoteItem> GeonoteItems { get; set; }

        public Topic()
        {

        }
    }
}
