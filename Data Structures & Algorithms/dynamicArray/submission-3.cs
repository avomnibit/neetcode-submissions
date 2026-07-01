public class DynamicArray {
    private int[] _values;
    private int _length;
    private int _capacity;
    
    
    public DynamicArray(int capacity) {
        _values = new int[capacity];
        _capacity = capacity;
    }

    public int Get(int i) {
        return _values[i];
    }

    public void Set(int i, int n) {
        _values[i]= n;
    }

    public void PushBack(int n) {
        if (_length == _capacity) Resize();
        _values[_length] = n;
        _length++;
    }

    public int PopBack() {
        _length--;
        return _values[_length]; 
    }

    private void Resize() {
        _capacity = _capacity*2;
        var newValues = new int[_capacity];
        Array.Copy(_values, newValues, _length);
        _values = newValues;
    }

    public int GetSize() {
        return _length;
    }

    public int GetCapacity() {
        return _capacity;
    }
}