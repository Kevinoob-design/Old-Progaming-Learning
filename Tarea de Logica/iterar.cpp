#include <iostream>

using namespace std;

int main(){
	
	int a;
	char b;
	
	cin >> b;
	
	a = char(b);
	cout << a << endl;
	
	if(a == 50){
		
		for(int i = 0; i <= b; i++){
		
			cout << i << endl;
		}
	}
	
	
	return 0;
}
