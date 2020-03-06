import os
from PIL import Image
sample_dir = "samples";
files_arr = os.listdir(sample_dir)

for i in range(len(files_arr)):
	#print(files_arr[i])
	temp_file = sample_dir + '/' + files_arr[i]
	im = Image.open(temp_file, 'r') # Can be many different formats.
	pix = im.load()
	temp_str = "["
	for x in range(im.size[0]):
		for y in range(im.size[1]):
			if (pix[x,y][0] > 0):
				temp_str += "1,"
			else:
				temp_str += "0,"
	temp_str = temp_str[:-1] + "],"
	print(temp_str)

for i in range(len(files_arr)):
	file_name_break = files_arr[i].split(".");
	if (file_name_break[0] == "cov"):
		print("[0,1],")
	else:
		print("[1,0],")