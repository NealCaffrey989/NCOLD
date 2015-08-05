% 输入150个城市的经纬度，输出这150个城市的距离矩阵

clear all
clc

load city150.dat
lat=city150(:,1:2);

[hA,hB]=size(lat);
r=6378.137;
lat=lat*2*pi/360;
for i=1:hA
    for j=1:hA
        x1=r*cos(lat(i,2))*cos(lat(i,1));
        x2=r*cos(lat(j,2))*cos(lat(j,1));
        y1=r*cos(lat(i,2))*sin(lat(i,1));
        y2=r*cos(lat(j,2))*sin(lat(j,1));
        z1=r*sin(lat(i,2));
        z2=r*sin(lat(j,2));
        l=sqrt((x1-x2)^2+(y1-y2)^2+(z1-z2)^2);
        ctar=2*asin(l/(2*r));
        s(i,j)=r*ctar*1.5;
    end
end

save distance150.dat s -ascii

