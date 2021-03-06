function [y,c]=kMeansCluster(m,k,isRand)  %输入经纬度、分类个数，得到

if nargin<3,
    isRand=0;
end

if nargin<2,
    k=1;
end   %输入参数个数判断

[maxRow,maxCol]=size(m);  

% 初始化中心值
 if isRand
     p=randperm(size(m,1));  %随机生成大小从1到150的一组数列P
     %help， p= randperm(n) returns a random permutation of the integers 1:n.
     for i=1:k
         c(i,:)=m(p(i),:); %为c矩阵赋值，c第i列为数列P第i个数所确定的m的列
     end
 else
     for i=1:k
         c(i,:)=m(p(i),:); 
     end
 end
 
 temp=zeros(maxRow,1); %初始化零向量
 
 while 1,
     d=DistMatrix(m,c); %计算 二级城市到配送中心 的距离
     [z,g]=min(d,[],2); %C = min(A,[],dim) returns the smallest elements along the dimension of A specified by scalar dim. For example, min(A,[],1) produces the minimum values along the first dimension (the rows) of A.
     if g==temp,
         break;         
     else
         temp=g;        %拷贝矩阵到临时变量中
     end
     for i=1:k
         f=find(g==i);
         if f           % only compute centroid if f is not empty
            c(i,:)=mean(m(find(g==i),:),1);   %%%%%%%
         end     
     end
 end
 
 y=[m,g];
     
     


