using System;
using System.Reflection;
using System.Collections.Generic;
using ConvensionApi.Model;

namespace ConvensionApi.Repository
{
    public interface ITopicRepository
    {
        Topic GetTopic(int topicId);

        IList<Topic> GetTopic();

        Topic SaveTopic(Topic topic);
    }
}


