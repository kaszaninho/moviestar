using MobileApp.Helpers;
using MobileApp.ViewModels.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Services
{
    public static class MovieApiService
    {

        public static async Task<MovieAllinfoResponse> GetMovieAllInfo(string id)
        {
            return await RequestHelper.SendRequestAsync<MovieAllinfoResponse>("api/MovieUser/getAllInfo/" + id, HttpMethod.Get, null);
        }
        public static async Task<IEnumerable<MovieInfoResponse>> GetAllMovies()
        {
            return await RequestHelper.SendRequestAsync<IEnumerable<MovieInfoResponse>>("api/Movie/withscreenings/", HttpMethod.Get, null);
        }
        public static async Task<MovieFullInfoReponse> GetMovie(int id)
        {
            return await RequestHelper.SendRequestAsync<MovieFullInfoReponse>("api/Movie/" + id, HttpMethod.Get, null);
        }
        public static async Task<IEnumerable<Screening>> GetScreeningsForUser(string id)
        {
            return await RequestHelper.SendRequestAsync<IEnumerable<Screening>>("/allscreenings/" + id, HttpMethod.Get, null);
        }
    }
}
