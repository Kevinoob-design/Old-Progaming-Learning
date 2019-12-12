//Realizar un programa que dado 8 valores capturados determine la variable que tenga el numero menor, evaluando con If anidados compuestos.

#include<iostream>
#include <stdlib.h>

using namespace std;

int main(){
	
	cout << "Introduzca 8 numeros. El programa comparara todos y escogera el mayor\n" << endl;
	
	int a, b, c, d, e, f, g, h;
	
	cout << "ingrese el valor de A: "; cin >> a;
	cout << "ingrese el valor de B: "; cin >> b;
	cout << "ingrese el valor de C: "; cin >> c;
	cout << "ingrese el valor de D: "; cin >> d;
	cout << "ingrese el valor de E: "; cin >> e;
	cout << "ingrese el valor de F: "; cin >> f;
	cout << "ingrese el valor de G: "; cin >> g;
	cout << "ingrese el valor de H: "; cin >> h;
	cout << "\n" << endl; 
		
	if (a>b) {
		if (a>c) {
			if (a>d) {
				if (a>e) {
					if (a>f) {
						if (a>g) {
							if (a>h) {
								cout << "El mayor es " << a << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				} else {
					if (e>f) {
						if (e>g) {
							if (e>h) {
								cout << "El mayor es " << e << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				}
			} else {
				if (d>e) {
					if (d>f) {
						if (d>g) {
							if (d>h) {
								cout << "El mayor es " << d << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				} else {
					if (e>f) {
						if (e>g) {
							if (e>h) {
								cout << "El mayor es " << e << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				}
			}
		} else {
			if (c>d) {
				if (c>e) {
					if (c>f) {
						if (c>g) {
							if (c>h) {
								cout << "El mayor es " << c << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				} else {
					if (e>f) {
						if (e>g) {
							if (e>h) {
								cout << "El mayor es " << e << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				}
			} else {
				if (d>e) {
					if (d>f) {
						if (d>g) {
							if (d>h) {
								cout << "El mayor es " << d << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				} else {
					if (e>f) {
						if (e>g) {
							if (e>h) {
								cout << "El mayor es " << e << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				}
			}
		}
	} else {
		if (b>c) {
			if (b>d) {
				if (b>e) {
					if (b>f) {
						if (b>g) {
							if (b>h) {
								cout << "El mayor es " << b << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				} else {
					if (e>f) {
						if (e>g) {
							if (e>h) {
								cout << "El mayor es " << e << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				}
			} else {
				if (d>e) {
					if (d>f) {
						if (d>g) {
							if (d>h) {
								cout << "El mayor es " << d << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << d << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				} else {
					if (e>f) {
						if (e>g) {
							if (e>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				}
			}
		} else {
			if (c>d) {
				if (c>e) {
					if (c>f) {
						if (c>g) {
							if (c>h) {
								cout << "El mayor es " << c << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				} else {
					if (e>f) {
						if (e>g) {
							if (e>h) {
								cout << "El mayor es " << e << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				}
			} else {
				if (c>e) {
					if (c>f) {
						if (c>g) {
							if (c>h) {
								cout << "El mayor es " << c << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					}
				} else {
					if (e>f) {
						if (e>g) {
							if (e>h) {
								cout << "El mayor es " << e << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						}
					} else {
						if (f>g) {
							if (f>h) {
								cout << "El mayor es " << f << endl;
							} else {
								cout << "El mayor es " << h << endl;
							}
						} else {
							if (g>h) {
								cout << "El mayor es " << g << endl;
							} else {
								cout << "EL mayor es " << h << endl;
							}
						}
					}
				}
			}
		}
	}
	
	system("pause");
	return 0;
}

