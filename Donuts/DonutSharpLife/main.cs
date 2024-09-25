using static System.Threading.Thread;
using static System.Console;
using static System.Math;
                 var(z,a,b)=(
             1760,1d,1d);for(;;){
          a+=.07;b+=.03;var(c,d,g,f,
        e,h,j)=(Cos(a),Sin(a),new char
      [z],Cos(b),Sin(b),new double[z],0d
    );for(var v=0;v<z;)g[v]=v++%80!=79?' '
   :'\n';for(;j<6.3;j    +=.07)for(var i=0d
   ;i<6.3;i+=.02)           {var(k,l,m,n)=(
  Cos(j),Sin(j)               ,Sin(i),Cos(i)
  );var o=k+2;                var(p,q)=(1/(m
  *o*d+l*c+5),m              *o*c-l*d);var(r
   ,s,t)=((int)(p          *30*(n*o*e-q*f)+
   40),(int)(12+15*      p*(n*o*f+q*e)),///
    (int)(8*((l*d-m*k*c)*e-m*k*d-l*c-n*k*f
      )));var u=r+80*s;if(s<22&&s>=0&&p>
        h[u]&&r>=0&&r<79)(h[u],g[u])=(
          p,".,-~:;=!*#$@"[Max(t,0)]
             );}Write(g);Sleep(50
                 );Clear();}