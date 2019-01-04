using GeneticAlgorithm.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public class GAClient
    {
        long iterationCounter;

        protected List<Node> Society { get; }

        public GAClient(List<Node> society)
        {
            this.Society = society;
        }

        public Task<List<Node>> OutputAsync() => new Task<List<Node>>(() => Output());

        public List<Node> Output()
        {
            /*
             * Gbest, which represents the solution with maximum influence spread.
             */

            throw new NotImplementedException();
        }

        protected virtual void Initialization()
        {
            iterationCounter = 0;
            DegreeDescendingInitialization();
        }

        protected virtual void Mutation()
        {
            /*
            * 1: Initilize X(mutation) with empty vectors;
            * 2:  Sort all nodes of V in degree - descending order;
            * 3: for each i<= n do
            * 4:  Xi(mutation) = Xi;
            * 5:  up - bound = K * (i + 5);
            * 6:  if up - bound >| V | then 
            * 7:   up - bound =| V |;
            * 8:  end if 
            * 9:  for each element Xij(mutation) ∈Xi(mutation) do
            * 10:   if random < f then 
            * 11:    Xij(mutation) = V.get(random(up - bound));
            * 12:   end if 
            * 13:  end for
            * 14: end for
            */

            throw new NotImplementedException();
        }

        protected virtual void Crossover()
        {
            /*
             * 1: Initialize X (crossover) with empty vectors; 
             * 2: Sort all nodes of V in degree-descending order; 
             * 3: for each i<=n do 
             * 4:  Xi (crossover) =empty; 
             * 5:  up-bound=k*(i+5);
             * 6:  if up-bound>|V| then 
             * 7:   up-bound=|V|; 
             * 8:  end if 
             * 9:  for each Xij (crossover) ∈Xi (crossover) do  
             * 10:   if random<cr then 
             * 11:    node=Xij (mutation); 
             * 12:    while node is in Xi (crossover)
             * 13:     node=V. get (random (up-bound)); 
             * 14:    end while 
             * 15:   else 
             * 16:    node=Xij; 
             * 17:    while node is in Xi (crossover) 
             * 18:     node=V. get (random (up-bound)); 
             * 19:    end while 
             * 20:   end if 
             * 21:   Xij (crossover) =node; 
             * 22:  end for 
             * 23: end fo
             */

            throw new NotImplementedException();
        }

        protected virtual void Selection()
        {
            /*
             * Initialize X(selection) with empty vectors; 
             * for each i<=n: Xi(selection)=arg max{ EDV( Xi ), EDV( Xi(crossover) ) }; 
             */
        }

        protected virtual void UpdateAndContinue()
        {
            /*
             * 1: X=X (selection); 
             * 2: Determine to stop or continue
             * 3: if g<gmax, go to step 2 and set g=g+1;otherwise, go to Step 6; 
             */

            throw new NotImplementedException();
        }

        protected virtual void LocalSearch()
        {
            /*
             * 1: Gbest=arg max {EDV (Xi)}; 
             * 2: Gbest=Local_Search(Gbest);
             */

            throw new NotImplementedException();
        }

        protected virtual void DegreeDescendingInitialization()
        {
            /*
            * Algorithm 3 Degree_Descending_Initialization (G, n, K, div) 
            * 1: Input: Graph G = (V, E), the size of population n, the size of seed set K, diversity degree div 
            * 2: Sort all nodes of V in degree-descending order 
            * 3: for each i <= n do 
            * 4:  Xi=Degree (G, K); 
            * 5:  up-bound=K*(i+5); 
            * 6:  if up-bound>|V| then 
            * 7:   up-bound=|V|; 
            * 8:  end if 
            * 9:  for each element Xij∈Xi do 
            * 10:   if random<div then 
            * 11:    Xij=V.get(random(up-bound)); 
            * 12:   end if 
            * 13:  end for 
            * 14: end for 
            * 15: Output: the initial population X.
            */

            throw new NotImplementedException();
        }

        protected virtual void DegreeDescendingSearch()
        {
            /*
             * 1: Input: Graph G = (V, E), the size of seed set K 
             * 2: Set S=empty 
             * 3: Sort all nodes of V in degree-descending order  
             * 4: for each i<=K do 
             * 5:  up-bound=i+5 
             * 6:  node=V.get (random (up-bound)) 
             * 7:  S.add (node)   
             * 8: end for 
             * 9: Output: node set S 
             */
        }

        protected virtual List<Node> InitializeMutation()
        {
            return new List<Node>();
        }

        protected virtual List<Node> InitializeCrossover()
        {
            return new List<Node>();
        }

        protected virtual void LocalSearch(List<Node> nodes)
        {
            /*
             * 1: Input: node set S. 
             * 2: S’=S; 
             * 3: for each node u in S do 
             * 4:  for each node v in Nb (u) do 
             * 5:   St=Replace(S’, u, v); 
             * 6:   if EDV (St)>EDV(S’) then 
             * 7:    S’=St; 
             * 8:   end if 
             * 9:  end for 
             * 10: end for  
             * 11: Output: node set S’ 
             */
        }

        protected virtual void EDV()
        {
            throw new NotImplementedException();
        }
    }
}
