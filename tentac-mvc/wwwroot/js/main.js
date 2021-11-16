"use strict";
import {
    handleClickEvents,
    renderMovies,
    renderSeries,
    renderSlider,
} from "./helper.js";

$(document).ready(async () => {
    await renderMovies();
    await renderSeries();
    handleClickEvents();
    renderSlider();
});
