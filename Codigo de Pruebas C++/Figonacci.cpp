#include <iostream>

using namespace std;

int main(){
	
	int N, A=1, B=1;
	
	cin >> N;
	
	for(int i = 1; i <= N; i++){
		
		cout << A <<", " << B << ", ";
		
		i++;
		A = A+B;
		B = A+B;
	}
	
	
	return 0;
}
