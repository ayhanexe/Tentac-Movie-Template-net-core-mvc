"use strict";
import { handleClickEvents, handleSearchPage } from "./helper.js";

$(document).ready(async () => {
  await handleSearchPage();
  handleClickEvents();
});
