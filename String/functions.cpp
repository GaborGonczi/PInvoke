#include "functions.h"
void set(const char* str, Obj*my) {
	strcpy(my->field, str);
}

char*get(Obj*my) {
	return my->field;
}

void deleteobj(Obj * my)
{
	delete my;
}

Obj * create()
{
	return new Obj;
}

