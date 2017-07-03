using System;
using System.Collections.Generic;
using System.Text;

namespace Ordena
{
    class Ordenar
    {
        // Método Bolha
        public void BubbleOrder(int[] v)
        {
            bool troca = true;
            int lim = v.Length - 1;
            int aux = 0;
            int k = 0;
            while(troca == true)
            {
                troca = false;
                for (int i = 0; i < lim; i++)
                { 
                    if(v[i]>v[i+1])
                    {
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        k = i;
                        troca = true;
                    }
                }
                lim = k;
            }
        }

        // Inserção
        public void InsertOrder(int[] v)
        {
            int j = 0;
            int i = 0;
            int chave = 0;
            for(j=0; j< v.Length;j++)
            {
                chave = v[j];
                i = j - 1;
                while(i>=0 && (v[i]>chave))
                {
                    v[i + 1] = v[i];
                    i = i - 1;
                }
                v[i + 1] = chave;
            }
        }

        // Seleção
        public void SelectionOrder(int[] v)
        {
            int i = 0;
            int j = 0;
            int temp = 0;
            int pos_menor = 0;

            for(i = 0; i <v.Length - 1;i++)
            {
                pos_menor = i;
                for(j=i+1;j<=v.Length-1;j++)
                {
                    if (v[j] < v[pos_menor])
                        pos_menor = j;
                }
                temp = v[i];
                v[i] = v[pos_menor];
                v[pos_menor] = temp;
            }
        }


        // Quick Sort
        public void QuickSortOrder(int[] v)
        {
            int[] v2 = {45,79,23,8,99,57,35,3,39,36,46}; 
            QuickSortOrder(v2, 0, v2.Length-1);
        }
        public void QuickSortOrder(int[] v, int esq, int dir)
        {
            int x, i, j, aux;
            i = esq;
            j = dir;
            x = v[(i + j) / 2];

            do
            {
                while (x > v[i])
                    i = i + 1;
                while (x < v[j])
                    j = j - 1;

                if (i <= j)
                {
                    aux = v[i];
                    v[i] = v[j];
                    v[j] = aux;
                    i = i + 1;
                    j = j - 1;
                }
            } while (i < j);

            if (esq < j)
                QuickSortOrder(v, esq, j);
            if (dir > i)
                QuickSortOrder(v, i, dir);
        }
        
 /*
        public void MergeSortOrder(int[] v)
        {
            MergeSortOrder( ref v, 0, v.Length-1);
        }

        void MergeSortOrder(ref int[] v, int left, int right)
        {
            int mid = (left + right) / 2;
            if (left < right)
            {
                MergeSortOrder(ref v, left, mid);
            
                MergeSortOrder(ref v, mid + 1, right);
            
                MergeSortOrder(ref v, left, mid, right);
            }
        }
        void MergeSortOrder(ref int[] v, int left, int mid, int right)
        {
            int[] tempArray = new int[right-left+1];
            int pos=0,lpos = left,rpos = mid + 1;
            while(lpos <= mid && rpos <= right)
            {
                if(v[lpos] < v[rpos])
                    tempArray[pos++] = v[lpos++];
                else
                    tempArray[pos++] = v[rpos++];
            }
            while(lpos <= mid)  tempArray[pos++] = v[lpos++];
            while(rpos <= right)tempArray[pos++] = v[rpos++];
            int i;
            for(i=0;i<pos;i++)
		        v[i+left] = tempArray[i];
            return;
        }*/





        public void MergeSortOrder(int[] v)
        {
            MergeSortOrder(v, 0, v.Length-1);
        }
        public void MergeSortOrder( int[] v, int inicio, int fim)
        {
            int l, r, m, i;
            int[] vtemp = new int[v.Length];

            if (inicio == fim)
                return;

            m = (inicio + fim) / 2;

            MergeSortOrder( v, inicio, m);
            MergeSortOrder( v, m + 1, fim);

            l = inicio;
            r = m + 1;

            for (i = inicio; i < fim; i++)
            {
                if (r > fim || (l <= m && v[l] <= v[r]))
                {
                    vtemp[i] = v[l];
                    l = l + 1;
                }
                else
                {
                    vtemp[i] = v[r];
                    r = r + 1;
                }
            }

            for (i = inicio; i < fim; i++)
            {
                v[i] = vtemp[i];
            }

        }

        

        /*
        public void MergeSortOrder(int[] v, int inicio, int fim)
        {
            int mid;

            if (fim > inicio)
            {
                mid = (fim + inicio) / 2;
                MergeSortOrder(v, inicio, mid);
                MergeSortOrder(v, (mid + 1), fim);

                MergeSortOrder(v, inicio, (mid + 1), fim);
            }
        }
        public void MergeSortOrder(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            if (left == right)
                return;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);


            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }

            while (left <= eol)
                temp[pos++] = numbers[left++];

            while (mid <= right)
                temp[pos++] = numbers[mid++];

            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        */

    }
}

