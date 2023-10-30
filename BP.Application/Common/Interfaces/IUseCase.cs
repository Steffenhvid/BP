using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Application.Common.Interfaces
{
    public interface IUseCase<Tinput, Toutput>
    {
        Task<Toutput> ExecuteAsync(Tinput input);
    }

    public interface IUseCase<in Tinput>
    {
        Task ExecuteAsync(Tinput input);
    }
}