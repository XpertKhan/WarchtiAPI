﻿"use strict";
var TempData = function () {

    var initTable = function () {
        var table = $('#kt_datatable');

        // begin first table
        table.dataTable({
            responsive: false,
            searchDelay: 500,
            processing: true, // for show progress bar
            serverSide: true, // for process server side
            filter: true, // this is for disable filter (search box)
            //orderMulti: true, // for disable multiple column at once
            orderable: true,
            "ajax": {
                "url": "/Admin/Announcement/LoadData",
                "type": "POST",
                "datatype": "json",
                data: {
                    // parameters for custom backend script demo
                    //columnsDef: [
                    //    'id', 'title', 'description', 'detail', 'workshop', 'Actions'],
                },
            },
            "columnDefs": [
                {
                    "name": "Id",
                    "data": "Id",
                    "targets": [0],
                    "visible": false,
                    searchable: false
                },
                {
                    "name": "Title",
                    "data": "Title",
                    "targets": [1],
                    "visible": true,
                    searchable: true
                },
                {
                    "name": "Description",
                    "data": "Description",
                    "targets": [2],
                    "visible": true,
                    searchable: true
                },
                {
                    "name": "Detail",
                    "data": "Detail",
                    "targets": [3],
                    "visible": true,
                    searchable: true
                },
                {
                    "name": "Workshop",
                    "data": "Workshop",
                    "targets": [4],
                    "visible": true,
                    searchable: true
                },
                {
                    "name": "Actions",
                    "data": "Actions",
                    "targets": [5],
                    title: 'Actions',
                    orderable: false,
                    searchable: false,
                    render: function (data, type, full, meta) {
                        return `
							<a href="#" class="btn btn-sm btn-clean btn-icon btn-edit" title="Edit details" data-id="${full.Id}">
								<i class="la la-edit text-warning"></i>
							</a>
							<a href="#" class="btn btn-sm btn-clean btn-icon btn-delete" title="Delete" data-id="${full.Id}">
								<i class="la la-trash text-danger"></i>
							</a>
						`;
                    },
                }
            ],
            //"columns": [
            //    { data: "id" },
            //    { data: "title" },
            //    { data: "description" },
            //    { data: "detail" },
            //    { data: "workshop" },
            //    { data: 'Actions', responsivePriority: -1 },
            //]
        });
    };

    return {

        //main function to initiate the module
        init: function () {
            initTable();
        },

    };

}();

jQuery(document).ready(function () {
    TempData.init();
});