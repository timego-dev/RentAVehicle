<main>
    <section class="row" aria-labelledby="aspnetTitle">
        <h1 id="aspnetTitle">Welcome!</h1>
        <p class="lead">Unlock Your Next Adventure with Our Vehicle Rental Service! Discover a Wide Range of Vehicles Ready to Take You Where You Want to Go. Rent with Ease Today!</p>
        <p>@Html.ActionLink("Explore All Vehicles", "Index", "Vehicle", New With {.area = ""}, New With {.class = "btn btn-primary btn-md"})</p>
    </section>
</main>
