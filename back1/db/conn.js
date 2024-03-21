const mongoose = require("mongoose");

mongoose
  .connect("mongodb://127.0.0.1:27017/bca")
  .then(() => {
    console.log("Sucessfully Connected to database");
  })
  .catch((e) => {
    console.log("Fail to connect database");
  });
