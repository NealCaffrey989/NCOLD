using System;
using System.Collections.Generic;
using System.Text;

namespace AntSystem
{
    public class AA
     {
        /**//// <summary>
        /// ����Ϣ�������ӳ̶�
        /// </summary>
        private int alpha;
        /**//// <summary>
        /// ����ʽ��Ϣ�������ӳ̶�
        /// </summary>
        private int beta;
        /**//// <summary>
        /// ��Ϣ�صĻӷ��ٶ�
        /// </summary>
        private double lo;
        /**//// <summary>
        /// ���о������
        /// </summary>
        private double[,] City;
        /**//// <summary>
        /// ��Ϣ�ؾ���
        /// </summary>
        private double[,] Message;
        /**//// <summary>
        /// opneList���ڴ����һ�����г���
        /// </summary>
        private Queue<int> openList=new Queue<int> ();
        /**//// <summary>
        /// closedList���ڴ���Ѿ����ʹ��ĳ���
        /// </summary>
        private Queue<int> closedList=new Queue<int> ();
        /**//// <summary>
        /// ����Ϻõ�·��
        /// </summary>
        private Queue <int> BestList=new Queue<int> ();
        private int Pro_time = 0;
        /**//////////////////////////////////////////////////////////
        /// <summary>
        /// ���캯�����γɳ��о������Ϣ�ؾ���
        /// </summary>
        /// <param name="city">���о������</param>
        /// <param name="Lo"> ��Ϣ�صĻӷ��ٶ�</param>
        public AA(double[,] city,double Lo,int Alpha,int Beta)
         {
            alpha = Alpha;
            beta = Beta;
            lo=Lo;
            int temp = Convert.ToInt32( Math.Sqrt(city.Length));
            City=new double [temp,temp];
            Message=new double [temp,temp];
            for (int i = 0; i < temp; i++)
             {
                for (int j = 0; j < temp; j++)
                {
                    City[i, j] = city[i, j];
                }
            }
            //��ʼ����Ϣ�ؾ���
            for (int i = 0; i < temp; i++)
             {
                for (int j = 0; j < temp; j++)
                 {
                    if (i != j)
                     {
                        Message[i, j] = (double)1 / (temp * temp - temp);
                    }
                }
            }
        }
        /**/////////////////////////////////////////////////////////////
        /// <summary>
        /// �ı���Ϣ�ؾ���closed_listΪ�Ϻõ�·��
        /// </summary>
        /// <param name="closed_list"></param>
        private void Change_Message(Queue<int> closed_list)
         {
            lock (this)
             {
                int[] temp_Array = new int[closed_list.Count];
                temp_Array = closed_list.ToArray();
                for (int i = 0; i < closed_list.Count - 1; i++)
                 {
                    Message[temp_Array[i], temp_Array[i + 1]] = Message[temp_Array[i], temp_Array[i + 1]] + lo / ((1 - lo) *Convert.ToInt32(Get_Weight(closed_list)+1));
                }
                Message[temp_Array[temp_Array.Length - 1], temp_Array[0]] = Message[temp_Array[temp_Array.Length - 1], temp_Array[0]] + lo / ((1 - lo) *Convert.ToInt32(Get_Weight(closed_list)));
                for (int i = 0; i < closed_list.Count; i++)
                 {
                    for (int j = 0; j < closed_list.Count; j++)
                     {
                        Message[i, j] = (1 - lo) * Message[i, j];
                    }
                }
            }
        }
        /**////////////////////////////////////////////////////////////////
        /// <summary>
        /// ����һ��������������Ӧ����·��
        /// </summary>
        /// <param name="closed_list"></param>
        /// <returns></returns>
        public double Get_Weight(Queue <int> closed_list)
         {
            lock (this)
             {
                double sum = 0;
                int[] temp_Array = new int[closed_list.Count];
                temp_Array = closed_list.ToArray();
                for (int i = 0; i < Convert.ToInt32(temp_Array.Length) - 1; i++)
                 {
                    sum = sum + City[temp_Array[i], temp_Array[i + 1]];
                }
                sum = sum + City[temp_Array[temp_Array.Length - 1], temp_Array[0]];
                return sum;
            }
        }
        /**///////////////////////////////////////////////////////////////
        /// <summary>
        /// ������i���к���һ�����߳��еļ��ϡ��������б�ż��뵽openList�С�
        /// �����ĳ��в������Ѿ�����closedList��
        /// </summary>
        /// <param name="i"></param>
        private void NextCity()
         {
            openList.Clear();
            int temp_int=Convert.ToInt32(Math.Sqrt(City.Length));
            for (int i = 0; i < temp_int; i++)
             {
                if (closedList.Contains(i) ==false)
                 {
                    openList.Enqueue(i);
                }
            }
        }
        /**///////////////////////////////////////////////////////////////
        /// <summary>
        /// ѡ��Ӧ��������·��ѡ����·A�����openList���ٰ�A���뵽openList��
        /// </summary>
        /// <returns></returns>
        private int choiceRoute()
         {
            int index = 0;//��¼ѡ��ĳ���
            Random random = new Random();
            double random_value =(double) random.NextDouble();//���ѡ��ĸ���
            int[] temp_Array=new int [openList.Count];
            temp_Array=openList.ToArray();
            double sum_Message = 0;//openList���нڵ������Ϣ��
            for (int i = 0; i < openList.Count; i++)
             {
                double eta = 1 / City[Pro_time, temp_Array[i]];
                sum_Message = sum_Message +Math.Pow(Message[Pro_time, temp_Array[i]],alpha)*Math.Pow (eta,beta);
            }
            double temp=0;
            for (int j = 0; j < openList.Count; j++)
             {
                double eta = 1 / City[Pro_time, temp_Array[j]];
                temp=temp+Math.Pow(Message[Pro_time,temp_Array[j]],alpha)*Math.Pow(eta,beta)/sum_Message;
                if (temp > random_value)
                 {
                    index = temp_Array [j];
                    break;
                }
            }
            openList.Clear();
            openList.Enqueue(index);
            return index;
        }
        /**//////////////////////////////////////////////////////////////
        public Queue<int> Main_DW()
          {
            BestList.Clear();
            /**////��ѭ��20��
            for (int i = 0; i < 20; i++)
             {
                /**////����nֻ����n=City'number Convert.ToInt32(Math.Sqrt(City.Length))
                for (int j = 0; j < Convert.ToInt32(Math.Sqrt(City.Length)); j++)
                 {
                    openList.Enqueue(0);
                    closedList.Clear();
                    while (openList.Count != 0 && closedList.Count != Convert.ToInt32(Math.Sqrt(City.Length)))
                     {
                        int temp = openList.Dequeue();
                        Pro_time = temp;
                        closedList.Enqueue(temp);
                        if (openList.Count == 0 && closedList.Count == Convert.ToInt32(Math.Sqrt(City.Length)))
                         {
                            if (BestList.Count == 0)
                             {
                                int[] temp_Array = new int[Convert.ToInt32(Math.Sqrt(City.Length))];
                                temp_Array = closedList.ToArray();
                                for (int k = 0; k < Convert.ToInt32(Math.Sqrt(City.Length)); k++)
                                 {
                                    BestList.Enqueue(temp_Array[k]);
                                }
                            }
                            if (Get_Weight(BestList) > Get_Weight(closedList))
                             {
                                BestList.Clear();
                                int[] temp_Array = new int[Convert.ToInt32(Math.Sqrt(City.Length))];
                                temp_Array = closedList.ToArray();
                                for (int k = 0; k < Convert.ToInt32(Math.Sqrt(City.Length)); k++)
                                 {
                                    BestList.Enqueue(temp_Array[k]);
                                }
                            }
                        }
                        NextCity();
                        choiceRoute();
                    }
                }
                Change_Message(BestList);//�޸���Ϣ��
            }
            return BestList;
        }
    }
}
 
 

