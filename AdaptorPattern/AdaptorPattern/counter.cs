interface Prototype_Counter{    bool Increment();    bool Decrement();    bool Read_Value();}class counter{    private Value val;    private int upper_limit;    public counter(int ul)    {        val = new Value(0);        upper_limit = ul;    }    public bool Increment()    {        int cur = val.read_val();
        if (cur < upper_limit)
        {
            val.step_up(1);
            return true;
        }
        else
        {
            return false;
        }             }    public bool Decrement()    {        int cur = val.read_val();
        if (cur > 0)
        {
            val.step_down(1);
            return true;
        }
        else
        {
            return false;
        }
    }}