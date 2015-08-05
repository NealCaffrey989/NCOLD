close all;
clear all;
clc

load city150.dat
load distance150.dat


m=city150(:,1:2); %m为150个城市的经纬度
demand=city150(:,3); %150个城市的需求
fre=city150(:,4); %150个城市的运送频率
S=distance150; %距离矩阵

CityCatag=length(S) ;
%CityCatag=150;

N=1200;  %迭代次数%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


FinalMinSumDis=10^20;

for k=1:CityCatag%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
   
    MinSumDis(k)=10^20;
    for kk=1:N
        [y,c]=kMeansCluster(m,k,1); %输入经纬度、聚类数、isRand，得到y，c 
        
        label=y(:,length(y(1,:)));
        
        SumDis(kk)=0;
        %确定DC位置
        for i=1:k
            index=find(label==i);
            while isempty(index),
                [y,c]=kMeansCluster(m,k,1);
                label=y(:,length(y(1,:)));
                for j=1:k
                    index=find(label==j);
                    if isempty(index)
                        break;
                    end
                end
            end
        end
        
 %根据模型计算最短距离       
        Sumdemand=0;
        Frequency=0;
       
        Dis=0;  %
        
        
        for i=1:k
            index=find(label==i);
            Sumdemand(i)=sum(demand(index));
            Frequency(i)=int32(mean(fre(index)));  %mean的用法    
            
            Distemp=10^20;
            
            for jj=1:length(index)  %对第i个DC范围内j个二级城市计算
                
                j=index(jj);
             
                Dis_temp=0;
                for jj_temp=1:length(index)  %通过循环累加该区域内所有的路径长度
                    j_temp=index(jj_temp);
                    
                    Dis_temp=Dis_temp+S(j,j_temp)*fre(j_temp);%%%%j是DC，j_temp是被循环的二级城市
                end  
                
                if  Dis_temp<Distemp  %%%%  PreCost_temp<PreCostmintemp
                    Distemp=Dis_temp;  %%%%PreCostmintemp=PreCost_temp;
                    %%%%PreCost(i)=PreCostmintemp;  
                    jc(i)=j; %确定DC
                end
            end
            Dis(i)=0;
            for jj=1:length(index)
                j=index(jj);
                %Dis(i)=Dis(i)+S(jc(i),j)*fre(j);   %
                Dis(i)=Dis(i)+S(jc(i),j)*fre(j)+Frequency(i)*S(jc(i),3);
                %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            end
        end
        SumDis(kk)=sum(Dis);   %%%%SumPreCost_kk=sum(PreCost);
        if SumDis(kk)<MinSumDis(k)  %%%%SumPreCost_kk<MinSumPreCost(k)
            MinSumDis(k)=SumDis(kk);  %%%%MinSumPreCost(k)=SumPreCost_kk;
            jcc=jc;
            label_final=label;
            Frequency_final=Frequency;
            for i=1:k    
                cc(i,:)=m(jcc(i),:);
                result(i,:)=[k jcc(i) Dis(i) Sumdemand(i) Frequency(i) kk];
            end
        end %end if SumPreCost(kk)<MinSumPreCost

    end %end for 1:N
    y1(k)=MinSumDis(k);%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%555
    if MinSumDis(k)<FinalMinSumDis   %%%%MinSumPreCost(k)<FinalMinSumPreCost
        FinalMinSumDis=MinSumDis(k);   %%%%FinalMinSumPreCost=MinSumPreCost(k);
        jcc_Min=jcc;
        Min_num=k;
        cc_Min=cc;
        label_final_Min=label_final;
        Frequency_Min=Frequency_final;
        result_Min=result;
    end %if MinSumPreCost(k)<FinalMinSumPreCost
    k
end %end for k=1:CityCatag


Min_num
jcc_Min
FinalMinSumDis
%%%%FinalMinSumPreCost


clf
hold on
plot(cc_Min(:,1),cc_Min(:,2),'ro')
% colors={'r.' 'gx' 'b+' 'ys' 'md' 'cv' 'k.' 'r*' 'g*' 'b*' 'y*' 'm*' 'c*' 'k*'  'r+' 'gd' 'bv' 'yd' 'm.' 'c+' 'k+' 'gv' 'bd' 'yv' 'mv' 'cv' 'kv'  'rv' 'g.' 'b.' 'y.' 'm.' 'c.' 'k.'  'rx' };
colors={'r.' 'g.' 'b.' 'y.' 'm.' 'c.' 'k.' 'rx' 'gx' 'bx' 'yx' 'mx' 'cx' 'kx'  'r+' 'g+' 'b+' 'y+' 'm+' 'c+' 'k+' 'rs' 'gs' 'bs' 'ys' 'ms' 'cs' 'ks'  'rd' 'gd' 'bd' 'yd' 'md' 'cd' 'kd' 'rv' 'gv' 'bv' 'yv' 'mv' 'cv' 'kv' };
for i=1:Min_num
   index = find(label_final_Min == i);
   if ~isempty(index)  
    dat=m(index,:);
    plot(dat(:,1),dat(:,2),colors{i})
   end
end    
hold off
%pause(0.1)
xlabel('longitude');
ylabel('latitude');


%找出各个DC管辖区域内的二级城市！！！
%for i=1:Min_num
%   index = find(label_final_Min == i);
%   if ~isempty(index)  
%    
%    i,index
%   end
%end    



