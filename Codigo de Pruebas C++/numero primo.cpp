#include <iostream>
#include <stdlib.h>

using namespace std;

int main(){
	
	int N, primo, divisores = 0;
	cin >> N;
	
	if(N > 1){
		
		for(int i = 1; i <= N; i++){
			
			for(int I = 1; I <= i; I++){

				primo = i%I;
				if(primo == 0){
					divisores += 1;
				}
			}
			if(divisores != 2){
				divisores = 0;
			}
			if(divisores == 2){
				cout << i << " Es un numero primo " << endl;
				divisores = 0;
			}
		}
	}
		
	return 0;
}
