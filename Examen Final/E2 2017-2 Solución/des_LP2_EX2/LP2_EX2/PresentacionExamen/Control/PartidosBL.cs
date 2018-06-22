using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class PartidosBL
    {
        public BindingList<ProyWebServ.partido> getPartidos(BindingList<int> nums)
        {
            //from list of pairs (sequence) get each match
            ProyWebServ.exWServiceClient cli = new ProyWebServ.exWServiceClient();
            int[] pares = new int[12];
            int cnt = 0;
            for (int i = 0; i < (nums.Count - 1); i++)
            {
                for (int j = i + 1; j < (nums.Count); j++)
                {
                    pares[cnt++] = nums[i];
                    pares[cnt++] = nums[j];
                }
            }
            return new BindingList<ProyWebServ.partido>(cli.getPartidos(pares));
        }

        public void updtPartido(int A, int B, int gA, int gB, bool j)
        {
            //update state of match (scores and actual happening)
            ProyWebServ.exWServiceClient cli = new ProyWebServ.exWServiceClient();
            cli.updtPartido(A, B, gA, gB, j);
        }

        public int[] getStatsEquipo(int eq, BindingList<ProyWebServ.partido> prtds)
        {
            //
            int[] arr = {0, 0, 0, 0, 0, 0};
            for (int i=0; i< prtds.Count; i++)
            {
                if (!prtds[i].jugado) continue;
                if (prtds[i].eqA == eq)
                {
                    arr[0] += 1;
                    arr[4] += prtds[i].gEqA;
                    arr[5] += prtds[i].gEqB;
                    if (prtds[i].gEqA > prtds[i].gEqB)
                    {
                        arr[1] += 1;
                    }else
                        if (prtds[i].gEqA == prtds[i].gEqB)
                    {
                        arr[2] += 1;
                    }
                    else
                    {
                        arr[3] += 1;
                    }
                    continue;
                }

                if (prtds[i].eqB == eq)
                {
                    arr[0] += 1;
                    arr[4] += prtds[i].gEqB;
                    arr[5] += prtds[i].gEqA;
                    if (prtds[i].gEqA < prtds[i].gEqB)
                    {
                        arr[1] += 1;
                    }
                    else
                        if (prtds[i].gEqA == prtds[i].gEqB)
                    {
                        arr[2] += 1;
                    }
                    else
                    {
                        arr[3] += 1;
                    }
                    continue;
                }
            }
            if (arr[0] == 0)
                return new int[1];
            else
                return arr;
        }
    }
}
