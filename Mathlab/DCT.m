function [] = DCT()
clear
close
N=100;                                                              
x=linspace(0,1,N);                                                   
y=heaviside(x-0.2)-heaviside(x-0.4)+heaviside(x-0.6)-heaviside(x-0.8);  
subplot(5,2,1),plot(x,y),title("Funkcja wejściowa"),hold on;                                                                                                                              

v=zeros(N);                                                            
v(1,:)=ones(N,1)*sqrt(1/N);   
for k=2:N                 
    for n=1:N           
        v(k,n)=sqrt(2/N)*cos(((k-1)*(n+1/2)*pi)/N);    
    end
end

yt=y*v';
yn=ones(N,1)*sqrt(1/N)*yt(1);  
yg=ones(N,1)*sqrt(1/N)*yt(1);
yb=ones(N,1)*sqrt(1/N)*yt(1);

for i=1:N
    for k=2:10     
        yn(i,1)=yn(i,1)+sqrt(2/N)*cos(((k-1)*(i+1/2)*pi)/N)*yt(k);
    end
end

for i=1:N
    for k=2:25    
        yg(i,1)=yg(i,1)+sqrt(2/N)*cos(((k-1)*(i+1/2)*pi)/N)*yt(k);
    end
end

for i=1:N
    for k=2:100  
        yb(i,1)=yb(i,1)+sqrt(2/N)*cos(((k-1)*(i+1/2)*pi)/N)*yt(k);
    end
end

subplot(5,2,3),plot(x,yn,'r-*'),hold on,plot(x,y,'k'),title("Aproksymacja dla 10 harmonicznych:");   
subplot(5,2,5);plot(x,yg,'g-*'),hold on,plot(x,y,'k'),title("Aproksymacja dla 25 harmonicznych:");   
subplot(5,2,7);plot(x,yb,'b-*'),hold on,plot(x,y,'k'),title("Aproksymacja dla 100 harmonicznych:");

e1 = abs(yn - y');
e2 = abs(yg - y');
e3 = abs(yb - y');

subplot(5,2,4),plot(x,e1,'r'),hold on,title("Błąd apro. dla n=10");
subplot(5,2,6),plot(x,e2,'g'),hold on,title("Błąd apro. dla n=25");
subplot(5,2,8),plot(x,e3,'b'),hold on,title("Błąd apro. dla n=100");

xn=ones(1,N)*sqrt(1/N)*yt(1);
for n=1:N
    for k=2:N
        xn(1,n)=xn(1,n)+sqrt(2/N)*cos(((k-1)*(n+1/2)*pi)/N)*yt(k);
    end
end

subplot(5,2,2),plot(x,xn,'m'),title("IDCT");

for u=3:N
    ys=ones(N,1)*sqrt(1/N)*yt(1);
    for i=1:N
        for k=2:u
            ys(i,1)=ys(i,1)+sqrt(2/N)*cos(((k-1)*(i+1/2)*pi)/N)*yt(k);
        end
    end
    
    MSE=0;
    for n=1:1:N
        MSE = MSE + (1/n)*(y(n)-ys(n))^2;
    end
    MSE_suma(1,(u-2))=MSE;
end

subplot(5,1,5),plot(MSE_suma,'k-o','LineWidth',1.5),title("Błąd średniokwadratowy MSE:")
    
end