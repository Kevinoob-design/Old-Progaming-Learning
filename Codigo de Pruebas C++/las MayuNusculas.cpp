#include <iostream>

using namespace std;

int main(){
	
	char Texto[27];
	
	cin >> Texto;
	
	for(int i = 0; i <= 26; i++){
		
		for(char I = 'A'; I <= 'z'; I++){
			
			if(Texto[i] == I){
				
				if(I >= 'a' && I <= 'z'){
					
					Texto[i] = I-32;
					I = 'z';
				}
				if(I >= 'A' && I <= 'Z'){
					
					Texto[i] = I+32;
					I = 'z';
				}
			}
		}
	}
	cout << Texto << endl;

	return 0;
}
