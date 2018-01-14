buf = new Buffer(26);
for (var i = 0 ; i < 26 ; i++) {
  buf[i] = i + 97;
  console.log("0x" + buf[i].toString(16));
}