window.addEventListener('DOMContentLoaded', event => {
    // Simple-DataTables
    // https://github.com/fiduswriter/Simple-DataTables/wiki

    const datatablesSimple = document.getElementById('datatablesSimple');
    if (datatablesSimple) {
        new simpleDatatables.DataTable(datatablesSimple, {
           
                perPage: 100,  // Muestra 10 registros por página
                perPageSelect: [100], // Opciones en el selector de registros por página
                searchable: true,  // Habilita la búsqueda
                fixedHeight: true,  // Ajusta la tabla para que tenga un alto fijo si hay menos filas
                labels: {
                placeholder: "Buscar...", // Texto de la barra de búsqueda
                perPage: "registros por pagina", // Selector de registros por página
                noRows: "No hay registros disponibles", // Mensaje cuando no hay datos
                info: "Mostrando {start} a {end} de {rows} registros", // Información de paginación
                loading: "Cargando...", // Mensaje de carga
                infoFiltered: " (filtrado de {rowsTotal} registros totales)", // Mensaje cuando se filtran datos
             
                }
    
        });
    }
});
