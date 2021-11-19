using Countries_Web.Entities;
using GraphQL;
using GraphQL.Client.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countries_Web
{
    public class Queries
    {
        private readonly IGraphQLClient _client;
        public Queries(IGraphQLClient client)
        {
            _client = client;
        }

        public async Task<List<Countries>> GetCountries()
        {
            var query = new GraphQLRequest
            {
            Query = @"
            query {
            countries (filter: {currency: {eq: \""EUR\""}}) 
            {
                name
                currency
                languages{name}
            }
            }"
        };
        var response = await _client.SendQueryAsync<ResponseCountryCollectionType>(query).ConfigureAwait(false);
        return response.Data.Countries;
        }
    }
}
