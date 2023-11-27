# SkiBooking
It is a MS VS solution containing both the frontend (Vue 3) and backend API (.NET 8). Clone and open the solution in VS2022 and hit F5.

# Frontend
The frontend is built using VUE3 Typescript. The application uses Vue router for routing, Vuex for state managment and bootstrap-vue-next for styles. It uses standard out of the box project structure. The ski booking workflow is as following:
- The default homepage on load calls an API to get a list of the available ski packages.
- The user can choose to see a particular ski package details. This takes them to a ski package detail page which calls an API to get ski package details.
- On ski detail page user can choose to go back to homepage or enter number packages and click on book to go to ski equipment page. Ski equipment page on load call API to get available ski equipments.
- On ski equipment page user can enter the quantities of different equipments and click next which takes them to lift tickets page.
- On lift tickets page user can enter number of tickets and days and complete the booking which takes them to booking summary page.
- On booking summary page, user selections and the total is displayed.

# Backend
The backend APIs are built using .NET8. There is minimal code in the API controllers and all the heavy lifting is done in the services which implement interfaces. The services are DI into the API. The idea behind is so that they can be easily unit tested. The project also uses Automapper to map the domain model objects to DTOs which are returned by the API.

# Design decisions
- Instead of directly exposing domain mode, DTOs are returned by the APIs.
- API controller are very lights and heavy lifting is done by the services which implement interfaces. This allows them to be easily unit tested.
- Use of textboxes instead of dropdowns for the quantities. This allows for bigger numbers when buying packages, lift tickets etc. especially for group bookings

# Future improvements
- Separate the API and the frontend into their own solutions
- Auth
- Frontend validation
- Unit testing
- Allow for removing items in a booking
