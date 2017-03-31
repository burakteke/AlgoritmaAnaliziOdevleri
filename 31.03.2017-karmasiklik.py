class Vec:
    def __init__(self,Labels,function):
        self.b=labels				//O(1)
        self.f=function
    def zero_vec(D):
        return Vec(D,{})			//O(1)
    def getitem(v,d):
        if d in v.f:
            return v.f[d]			//O(1)
        else:
            return o
    def scalar_mul(v,alpha):
        return Vec(v.D,{d:alpha*getitem(v,d) for d in v.D})	 //O(n^2)
    def add(u,v):
        return Vec(u.D,{d:getitem(u,d)*getitem(v,d) for d in u.D})  //O(n^3)
    def neg(v):
        return scalar_mul(v,-1)                      //O(n^3)
    def printVec(v_1):                           // O(n)
        for d in v_1.D:
            if d in v_1.f:
                print(d,v_1.f[d])
