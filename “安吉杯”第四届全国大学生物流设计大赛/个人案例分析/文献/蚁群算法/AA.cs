using System;
using System.Collections.Generic;
using System.Text;

namespace AntSystem
{
    public class AA
     {
        /**//// <summary>
        /// 对信息量的重视程度
        /// </summary>
        private int alpha;
        /**//// <summary>
        /// 启发式信息的受重视程度
        /// </summary>
        private int beta;
        /**//// <summary>
        /// 信息素的挥发速度
        /// </summary>
        private double lo;
        /**//// <summary>
        /// 城市距离矩阵
        /// </summary>
        private double[,] City;
        /**//// <summary>
        /// 信息素矩阵
        /// </summary>
        private double[,] Message;
        /**//// <summary>
        /// opneList用于存放下一步可行城市
        /// </summary>
        private Queue<int> openList=new Queue<int> ();
        /**//// <summary>
        /// closedList用于存放已经访问过的城市
        /// </summary>
        private Queue<int> closedList=new Queue<int> ();
        /**//// <summary>
        /// 储存较好的路径
        /// </summary>
        private Queue <int> BestList=new Queue<int> ();
        private int Pro_time = 0;
        /**//////////////////////////////////////////////////////////
        /// <summary>
        /// 构造函数：形成城市距离和信息素矩阵
        /// </summary>
        /// <param name="city">城市距离矩阵</param>
        /// <param name="Lo"> 信息素的挥发速度</param>
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
            //初始化信息素矩阵
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
        /// 改变信息素矩阵，closed_list为较好的路径
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
        /// 输入一个链表，计算出其对应的总路径
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
        /// 产生到i城市后，下一个可走城市的集合。并将城市编号加入到openList中。
        /// 产生的城市不可以已经存在closedList中
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
        /// 选择应该走那条路，选择完路A后，清空openList，再把A加入到openList中
        /// </summary>
        /// <returns></returns>
        private int choiceRoute()
         {
            int index = 0;//记录选择的城市
            Random random = new Random();
            double random_value =(double) random.NextDouble();//随机选择的概率
            int[] temp_Array=new int [openList.Count];
            temp_Array=openList.ToArray();
            double sum_Message = 0;//openList所有节点的总信息量
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
            /**////共循环20次
            for (int i = 0; i < 20; i++)
             {
                /**////共有n只蚂蚁n=City'number Convert.ToInt32(Math.Sqrt(City.Length))
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
                Change_Message(BestList);//修改信息量
            }
            return BestList;
        }
    }
}
 
 

