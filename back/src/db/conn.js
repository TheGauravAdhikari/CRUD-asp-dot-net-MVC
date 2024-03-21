const mongoose = require("mongoose");
mongoose
  .connect("mongodb://127.0.0.1:27017/abc")
  .then(() => {
    console.log("Connection Sucessful");
  })
  .catch((e) => {
    console.log("Can't Connection to DB", e);
  });
